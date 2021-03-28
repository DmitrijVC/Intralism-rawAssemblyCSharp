using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000297 RID: 663
	[RequireComponent(typeof(RectTransform))]
	public class ReorderableListElement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IEventSystemHandler
	{
		// Token: 0x06009F5E RID: 40798 RVA: 0x003B3708 File Offset: 0x003B1908
		private void HFOGPOJOHKI()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.LFCMGJDJMLK().childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x003B37D4 File Offset: 0x003B19D4
		public void NLJEDNJFBFL(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject(" region").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.BHNJPPKOLAN();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x003B3A08 File Offset: 0x003B1C08
		public void FKOHMBBKPDL(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("_Value").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.EIILLJMLHOA();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009F61 RID: 40801 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void Init(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F62 RID: 40802 RVA: 0x003B3C50 File Offset: 0x003B1E50
		public void EMJFAENMJCE(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("_Distortion").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.NAFHKBILADA();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x003B3E84 File Offset: 0x003B2084
		public void HEFBIFIBBNI(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.OOFDENBBKCN();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.NHFKHDILLBJ();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.Content, true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F64 RID: 40804 RVA: 0x003B402C File Offset: 0x003B222C
		private void NHFKHDILLBJ()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.LFCMGJDJMLK().childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.GCILADCHBGI().GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void NKLCNJEIAFB(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x003B40F8 File Offset: 0x003B22F8
		public void HKFJKIJGBIF(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("tagElement").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.PFADJFMBGFI();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void BFMEBNFGCEA(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x003B432C File Offset: 0x003B252C
		public void NPNCDGELGKA(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("Bad parameters for delete! Use <key>").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.NHFKHDILLBJ();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F69 RID: 40809 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void NFKKPHKGIEI(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void FIMJABKECNG(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x003B4560 File Offset: 0x003B2760
		public void NAFLLKBCDKM(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.CNFDODFILOJ();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), false);
				}
				float num = 265f;
				int siblingIndex = 0;
				float num2 = 1944f;
				for (int j = 1; j < this.FOJKIJGIPGN.Content.childCount; j += 0)
				{
					RectTransform component = this.FOJKIJGIPGN.GCILADCHBGI().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.MFHCMFAPMDF();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(false);
			}
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void AOEEOKNJDCK(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void LLAHPNGMEOO(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x003B47D0 File Offset: 0x003B29D0
		public void OnBeginDrag(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("Fake").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.OOFDENBBKCN();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009F6F RID: 40815 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void PIEPPKMBJHI(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x003B4A04 File Offset: 0x003B2C04
		public void MFALIDFFLMO(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 1; i < this.NFDDIBHDJOB.Count; i++)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.HFOGPOJOHKI();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.Content, false);
				}
				float num = 1932f;
				int siblingIndex = 0;
				float num2 = 411f;
				for (int j = 0; j < this.FOJKIJGIPGN.GCILADCHBGI().childCount; j++)
				{
					RectTransform component = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.IIBAEJBLKLP();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(true);
			}
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x003B4C74 File Offset: 0x003B2E74
		public void NFPNJKALHKD(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("player.xp").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.AJODBHLAJNH();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x003B4EA8 File Offset: 0x003B30A8
		private void LGFNDMGDFLC()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.LFCMGJDJMLK().childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.Content.GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F73 RID: 40819 RVA: 0x003B4F74 File Offset: 0x003B3174
		private void LIOLDCOHBDK()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.CJHDAEEIOIH().childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F74 RID: 40820 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void LCGMHCBNCDM(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F75 RID: 40821 RVA: 0x003B5040 File Offset: 0x003B3240
		public void INCJANDEKNL(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.EIILLJMLHOA();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.LFCMGJDJMLK(), true);
				}
				float num = 1039f;
				int siblingIndex = 0;
				float num2 = 1152f;
				for (int j = 1; j < this.FOJKIJGIPGN.GCILADCHBGI().childCount; j++)
				{
					RectTransform component = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.FHLLGANEFGH();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(false);
			}
		}

		// Token: 0x06009F76 RID: 40822 RVA: 0x003B52B0 File Offset: 0x003B34B0
		private void AJODBHLAJNH()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.CJHDAEEIOIH().childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F77 RID: 40823 RVA: 0x003B537C File Offset: 0x003B357C
		public void DHCMECJGJNK(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("help").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.HNILKCAIFOA();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F78 RID: 40824 RVA: 0x003B55B0 File Offset: 0x003B37B0
		public void GIKAADBPOKK(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.OOFDENBBKCN();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), true);
				}
				float num = 1461f;
				int siblingIndex = 0;
				float num2 = 1010f;
				for (int j = 1; j < this.FOJKIJGIPGN.CJHDAEEIOIH().childCount; j++)
				{
					RectTransform component = this.FOJKIJGIPGN.Content.GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.FHLLGANEFGH();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(false);
			}
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x003B5820 File Offset: 0x003B3A20
		public void BNMLHPCDJNJ(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("OnEvent: {0}").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.EKMPPALHKOF();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x003B5A54 File Offset: 0x003B3C54
		public void NDIOKCDFLHL(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.PFADJFMBGFI();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.PFADJFMBGFI();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.LFCMGJDJMLK(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x003B5BFC File Offset: 0x003B3DFC
		public void IPHPFCAMMFO(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.BHNJPPKOLAN();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.NAFHKBILADA();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x003B5DA4 File Offset: 0x003B3FA4
		public void MOAEAMDAMIN(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.FHLLGANEFGH();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.IIBAEJBLKLP();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x003B5F4C File Offset: 0x003B414C
		public void EKPALBJACEG(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("FrostCanvas").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.LGFNDMGDFLC();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x003B6180 File Offset: 0x003B4380
		public void PDFJHANELBN(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("USE_DIAG_SEARCH").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.IIBAEJBLKLP();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x003B63B4 File Offset: 0x003B45B4
		public void ADENFKGKBGG(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.LIOLDCOHBDK();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.LIOLDCOHBDK();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void LHIEKHPLMFI(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x003B655C File Offset: 0x003B475C
		public void BKIJDBCFKKF(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject(".lastCheckpoint.playerdistance").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.MFHCMFAPMDF();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x003B6790 File Offset: 0x003B4990
		public void BPJBOILFGKB(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("Tab1Content").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.NHFKHDILLBJ();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x003B69C4 File Offset: 0x003B4BC4
		private void LINCDCIJMJK()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.Content.childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x003B6A90 File Offset: 0x003B4C90
		public void GAIKALMKMIB(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.MFHCMFAPMDF();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.LFCMGJDJMLK(), true);
				}
				float num = 473f;
				int siblingIndex = 0;
				float num2 = 780f;
				for (int j = 1; j < this.FOJKIJGIPGN.CJHDAEEIOIH().childCount; j += 0)
				{
					RectTransform component = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.EKMPPALHKOF();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(true);
			}
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x003B6D00 File Offset: 0x003B4F00
		public void LHJNINMODAI(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.IIBAEJBLKLP();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.OOFDENBBKCN();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x003B6EA8 File Offset: 0x003B50A8
		public void ENKHGEKPKOL(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.CNFDODFILOJ();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.LFCMGJDJMLK(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.DNHKEDIKOMF();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.GCILADCHBGI(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x003B7050 File Offset: 0x003B5250
		private void MBFLIAODCMA()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.CJHDAEEIOIH().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.GCILADCHBGI().GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x003B711C File Offset: 0x003B531C
		private void HNILKCAIFOA()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.Content.childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.GCILADCHBGI().GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x003B71E8 File Offset: 0x003B53E8
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i++)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.OOFDENBBKCN();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.Content, false);
				}
				float num = float.PositiveInfinity;
				int siblingIndex = 0;
				float num2 = 0f;
				for (int j = 0; j < this.FOJKIJGIPGN.Content.childCount; j++)
				{
					RectTransform component = this.FOJKIJGIPGN.Content.GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.OOFDENBBKCN();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(true);
			}
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x003B7458 File Offset: 0x003B5658
		public void LMOFLHPALPC(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.NHFKHDILLBJ();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.NHFKHDILLBJ();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x003B7600 File Offset: 0x003B5800
		public void AMCCALKONAG(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 1; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.PFADJFMBGFI();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), true);
				}
				float num = 949f;
				int siblingIndex = 1;
				float num2 = 1044f;
				for (int j = 0; j < this.FOJKIJGIPGN.CJHDAEEIOIH().childCount; j++)
				{
					RectTransform component = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.CNFDODFILOJ();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(true);
			}
		}

		// Token: 0x06009F8C RID: 40844 RVA: 0x003B7870 File Offset: 0x003B5A70
		public void NOADJGHHGAK(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.AJODBHLAJNH();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.LINCDCIJMJK();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.GCILADCHBGI(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F8D RID: 40845 RVA: 0x003B7A18 File Offset: 0x003B5C18
		private void IIBAEJBLKLP()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.GCILADCHBGI().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.Content.GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F8E RID: 40846 RVA: 0x003B7AE4 File Offset: 0x003B5CE4
		public void MKPPECOCKKJ(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("CameraFilterPack/Edge_Neon").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.EKMPPALHKOF();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F8F RID: 40847 RVA: 0x003B7D18 File Offset: 0x003B5F18
		public void HGPBDNOJBFG(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.LGFNDMGDFLC();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.NAFHKBILADA();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.LFCMGJDJMLK(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x003B7EC0 File Offset: 0x003B60C0
		public void DAMIKAIBKFH(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.MFHCMFAPMDF();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), false);
				}
				float num = 625f;
				int siblingIndex = 0;
				float num2 = 1291f;
				for (int j = 0; j < this.FOJKIJGIPGN.GCILADCHBGI().childCount; j += 0)
				{
					RectTransform component = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.DNHKEDIKOMF();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(false);
			}
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void MOKHHEMAJBJ(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x003B8130 File Offset: 0x003B6330
		public void JLBDLJNKNKN(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 1; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.EKMPPALHKOF();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), false);
				}
				float num = 1853f;
				int siblingIndex = 0;
				float num2 = 515f;
				for (int j = 1; j < this.FOJKIJGIPGN.CJHDAEEIOIH().childCount; j++)
				{
					RectTransform component = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.CNFDODFILOJ();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(false);
			}
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x003B83A0 File Offset: 0x003B65A0
		public void PKNGJGMIPLF(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 1; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.NAFHKBILADA();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), true);
				}
				float num = 1732f;
				int siblingIndex = 0;
				float num2 = 1257f;
				for (int j = 1; j < this.FOJKIJGIPGN.Content.childCount; j += 0)
				{
					RectTransform component = this.FOJKIJGIPGN.Content.GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.PFADJFMBGFI();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(true);
			}
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x003B8610 File Offset: 0x003B6810
		public void NBEEABGEMFP(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.LGFNDMGDFLC();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.Content, true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.FHLLGANEFGH();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x003B87B8 File Offset: 0x003B69B8
		private void CNFDODFILOJ()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.GCILADCHBGI().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.Content.GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void DPOELEBIAOE(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x003B8884 File Offset: 0x003B6A84
		private void EKMPPALHKOF()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.GCILADCHBGI().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void OCHADIJNDJK(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void LBICLFNOLAK(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x003B8950 File Offset: 0x003B6B50
		public void FPFOHNHFKGM(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("_ScreenResolution").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.MBFLIAODCMA();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x003B8B84 File Offset: 0x003B6D84
		public void DEEFIPFBLNE(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("_Bullet_9").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.OOFDENBBKCN();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x003B8DCC File Offset: 0x003B6FCC
		public void IJOBGAJLKEH(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.LIOLDCOHBDK();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.LFCMGJDJMLK(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.AJODBHLAJNH();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.LFCMGJDJMLK(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x003B8F74 File Offset: 0x003B7174
		public void MMHPGDMCAEO(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i++)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.EIILLJMLHOA();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), false);
				}
				float num = 976f;
				int siblingIndex = 0;
				float num2 = 1810f;
				for (int j = 1; j < this.FOJKIJGIPGN.GCILADCHBGI().childCount; j += 0)
				{
					RectTransform component = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.CNFDODFILOJ();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(false);
			}
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x003B91E4 File Offset: 0x003B73E4
		public void FONFAMMMONH(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("Add Environment Object").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.IIBAEJBLKLP();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x003B9418 File Offset: 0x003B7618
		public void PMBCOKBPBBJ(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject(" [").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.LGFNDMGDFLC();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009FA1 RID: 40865 RVA: 0x003B964C File Offset: 0x003B784C
		private void FHLLGANEFGH()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.GCILADCHBGI().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.Content.GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x003B9718 File Offset: 0x003B7918
		public void NLIJJACHCPA(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("SetSatelliteSensitivity").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.OOFDENBBKCN();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x003B994C File Offset: 0x003B7B4C
		public void NOMEIEGJMGL(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.LGFNDMGDFLC();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.LFCMGJDJMLK(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.LINCDCIJMJK();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.Content, true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x003B9AF4 File Offset: 0x003B7CF4
		private void PFADJFMBGFI()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.LFCMGJDJMLK().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x003B9BC0 File Offset: 0x003B7DC0
		public void KGDEEEJFJPL(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.DNHKEDIKOMF();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.AJODBHLAJNH();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x003B9D68 File Offset: 0x003B7F68
		public void MCGPPJHHMIG(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("[PlayerController] ").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.MFHCMFAPMDF();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009FA7 RID: 40871 RVA: 0x003B9F9C File Offset: 0x003B819C
		public void GHMBCHFLLEM(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("_Value").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.LIOLDCOHBDK();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x003BA1D0 File Offset: 0x003B83D0
		public void BNKEBNPLBLB(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 1; i < this.NFDDIBHDJOB.Count; i++)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.DNHKEDIKOMF();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.LFCMGJDJMLK(), false);
				}
				float num = 68f;
				int siblingIndex = 1;
				float num2 = 1534f;
				for (int j = 0; j < this.FOJKIJGIPGN.Content.childCount; j += 0)
				{
					RectTransform component = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.BHNJPPKOLAN();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(true);
			}
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x003BA440 File Offset: 0x003B8640
		public void COMGOCAKBLD(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("CameraFilterPack/Blend2Camera_Blend").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.LGFNDMGDFLC();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x003BA674 File Offset: 0x003B8874
		public void COHPGPDOPND(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("Set particless emission (glow)").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.LINCDCIJMJK();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x003BA8A8 File Offset: 0x003B8AA8
		private void DNHKEDIKOMF()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.CJHDAEEIOIH().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.GCILADCHBGI().GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x003BA974 File Offset: 0x003B8B74
		public void MLHFDGPJEFK(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("request").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.AJODBHLAJNH();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x003BABA8 File Offset: 0x003B8DA8
		public void MOOECPLMJBG(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.MFHCMFAPMDF();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.Content, false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 0
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.DNHKEDIKOMF();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.GCILADCHBGI(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x003BAD50 File Offset: 0x003B8F50
		public void HADDDHKBLMO(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("SelectorMusicToggle").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.LIOLDCOHBDK();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x003BAF84 File Offset: 0x003B9184
		private void MFHCMFAPMDF()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.Content.childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.LFCMGJDJMLK().GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x003BB050 File Offset: 0x003B9250
		public void LODEFJCFGJI(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = true;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.HNILKCAIFOA();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.GCILADCHBGI(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.MFHCMFAPMDF();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.CJHDAEEIOIH(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x003BB1F8 File Offset: 0x003B93F8
		private void BHNJPPKOLAN()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.LFCMGJDJMLK().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.Content.GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void LHAENMGOBMM(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void CAJFKNFJEKC(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x003BB2C4 File Offset: 0x003B94C4
		public void HDABKANELKP(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("maps.").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.NAFHKBILADA();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void KDJHONILJGK(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x003BB4F8 File Offset: 0x003B96F8
		private void EIILLJMLHOA()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.GCILADCHBGI().childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(1);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FB7 RID: 40887 RVA: 0x003BB5C4 File Offset: 0x003B97C4
		private void OOFDENBBKCN()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.Content.childCount > 0)
			{
				Transform child = this.FOJKIJGIPGN.Content.GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x003B3C3A File Offset: 0x003B1E3A
		public void ALGKENJGNLL(ReorderableList LMPCOPFGELG)
		{
			this.CPLNKKEKGNO = LMPCOPFGELG;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x003BB690 File Offset: 0x003B9890
		public void NDPOELJLHOF(PointerEventData OLIIPKODDIN)
		{
			if (!this.NDGBBDKAJEN)
			{
				return;
			}
			this.LLCHHNEHDAB.position = OLIIPKODDIN.position;
			EventSystem.current.RaycastAll(OLIIPKODDIN, this.NFDDIBHDJOB);
			for (int i = 0; i < this.NFDDIBHDJOB.Count; i += 0)
			{
				this.FOJKIJGIPGN = this.NFDDIBHDJOB[i].gameObject.GetComponent<ReorderableList>();
				if (this.FOJKIJGIPGN != null)
				{
					break;
				}
			}
			if (this.FOJKIJGIPGN == null || !this.FOJKIJGIPGN.IsDropable)
			{
				this.NHFKHDILLBJ();
				this.JMKLJAKMNKK.transform.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			}
			else
			{
				if (this.JMKLJAKMNKK.parent != this.FOJKIJGIPGN)
				{
					this.JMKLJAKMNKK.SetParent(this.FOJKIJGIPGN.CJHDAEEIOIH(), false);
				}
				float num = 986f;
				int siblingIndex = 0;
				float num2 = 1505f;
				for (int j = 1; j < this.FOJKIJGIPGN.LFCMGJDJMLK().childCount; j += 0)
				{
					RectTransform component = this.FOJKIJGIPGN.GCILADCHBGI().GetChild(j).GetComponent<RectTransform>();
					if (this.FOJKIJGIPGN.ContentLayout is VerticalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is HorizontalLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x);
					}
					else if (this.FOJKIJGIPGN.ContentLayout is GridLayoutGroup)
					{
						num2 = Mathf.Abs(component.position.x - OLIIPKODDIN.position.x) + Mathf.Abs(component.position.y - OLIIPKODDIN.position.y);
					}
					if (num2 < num)
					{
						num = num2;
						siblingIndex = j;
					}
				}
				this.MFHCMFAPMDF();
				this.JMKLJAKMNKK.SetSiblingIndex(siblingIndex);
				this.JMKLJAKMNKK.gameObject.SetActive(false);
			}
		}

		// Token: 0x06009FBA RID: 40890 RVA: 0x003BB900 File Offset: 0x003B9B00
		private void NAFHKBILADA()
		{
			Vector2 sizeDelta = this.EJCHCCIDKAJ;
			if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable && this.FOJKIJGIPGN.CJHDAEEIOIH().childCount > 1)
			{
				Transform child = this.FOJKIJGIPGN.CJHDAEEIOIH().GetChild(0);
				if (child != null)
				{
					sizeDelta = child.GetComponent<RectTransform>().rect.size;
				}
			}
			this.LLCHHNEHDAB.sizeDelta = sizeDelta;
			LayoutElement hbeikfefdda = this.HBEIKFEFDDA;
			float num = sizeDelta.y;
			this.JCBPLHHNOON.preferredHeight = num;
			hbeikfefdda.preferredHeight = num;
			LayoutElement hbeikfefdda2 = this.HBEIKFEFDDA;
			num = sizeDelta.x;
			this.JCBPLHHNOON.preferredWidth = num;
			hbeikfefdda2.preferredWidth = num;
		}

		// Token: 0x06009FBB RID: 40891 RVA: 0x003BB9CC File Offset: 0x003B9BCC
		public void LOBDGNAADPM(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, false);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("_TimeX").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.DNHKEDIKOMF();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = false;
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x003BBC00 File Offset: 0x003B9E00
		public void OnEndDrag(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.OOFDENBBKCN();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.Content, false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.OOFDENBBKCN();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.Content, false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009FBD RID: 40893 RVA: 0x003BBDA8 File Offset: 0x003B9FA8
		public void PJOAOFCGJLA(PointerEventData OLIIPKODDIN)
		{
			this.NDGBBDKAJEN = false;
			if (this.LLCHHNEHDAB != null)
			{
				if (this.FOJKIJGIPGN != null && this.FOJKIJGIPGN.IsDropable)
				{
					this.MBFLIAODCMA();
					this.LLCHHNEHDAB.SetParent(this.FOJKIJGIPGN.LFCMGJDJMLK(), false);
					this.LLCHHNEHDAB.SetSiblingIndex(this.JMKLJAKMNKK.GetSiblingIndex());
					if (this.CPLNKKEKGNO.OnElementDropped != null)
					{
						this.CPLNKKEKGNO.OnElementDropped.Invoke(new ReorderableList.ReorderableListEventStruct
						{
							DroppedObject = this.LLCHHNEHDAB.gameObject,
							IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
							SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
							FromList = this.CPLNKKEKGNO,
							FromIndex = this.CMLMOJNPBDP,
							ToList = this.FOJKIJGIPGN,
							ToIndex = this.JMKLJAKMNKK.GetSiblingIndex() - 1
						});
					}
				}
				else if (this.CPLNKKEKGNO.CloneDraggedObject)
				{
					Object.Destroy(this.LLCHHNEHDAB.gameObject);
				}
				else
				{
					this.AJODBHLAJNH();
					this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.LFCMGJDJMLK(), true);
					this.LLCHHNEHDAB.SetSiblingIndex(this.CMLMOJNPBDP);
				}
			}
			if (this.JMKLJAKMNKK != null)
			{
				Object.Destroy(this.JMKLJAKMNKK.gameObject);
			}
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x003BBF50 File Offset: 0x003BA150
		public void ODFJDFIPIMF(PointerEventData OLIIPKODDIN)
		{
			if (this.CPLNKKEKGNO == null)
			{
				return;
			}
			if (!this.CPLNKKEKGNO.IsDraggable)
			{
				this.LLCHHNEHDAB = null;
				return;
			}
			if (!this.CPLNKKEKGNO.CloneDraggedObject)
			{
				this.LLCHHNEHDAB = this.BBNGEJDDCIG;
				this.CMLMOJNPBDP = this.BBNGEJDDCIG.GetSiblingIndex();
				if (this.CPLNKKEKGNO.OnElementRemoved != null)
				{
					this.CPLNKKEKGNO.OnElementRemoved.Invoke(new ReorderableList.ReorderableListEventStruct
					{
						DroppedObject = this.LLCHHNEHDAB.gameObject,
						IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
						SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
						FromList = this.CPLNKKEKGNO,
						FromIndex = this.CMLMOJNPBDP
					});
				}
			}
			else
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				this.LLCHHNEHDAB = gameObject.GetComponent<RectTransform>();
			}
			this.EJCHCCIDKAJ = base.gameObject.GetComponent<RectTransform>().rect.size;
			this.JCBPLHHNOON = this.LLCHHNEHDAB.GetComponent<LayoutElement>();
			this.LLCHHNEHDAB.SetParent(this.CPLNKKEKGNO.DraggableArea, true);
			this.LLCHHNEHDAB.SetAsLastSibling();
			this.JMKLJAKMNKK = new GameObject("Added GameObject to prefabDictionary: ").AddComponent<RectTransform>();
			this.HBEIKFEFDDA = this.JMKLJAKMNKK.gameObject.AddComponent<LayoutElement>();
			this.EIILLJMLHOA();
			if (this.CPLNKKEKGNO.OnElementGrabbed != null)
			{
				this.CPLNKKEKGNO.OnElementGrabbed.Invoke(new ReorderableList.ReorderableListEventStruct
				{
					DroppedObject = this.LLCHHNEHDAB.gameObject,
					IsAClone = this.CPLNKKEKGNO.CloneDraggedObject,
					SourceObject = ((!this.CPLNKKEKGNO.CloneDraggedObject) ? this.LLCHHNEHDAB.gameObject : base.gameObject),
					FromList = this.CPLNKKEKGNO,
					FromIndex = this.CMLMOJNPBDP
				});
			}
			this.NDGBBDKAJEN = true;
		}

		// Token: 0x0400122A RID: 4650
		private readonly List<RaycastResult> NFDDIBHDJOB = new List<RaycastResult>();

		// Token: 0x0400122B RID: 4651
		private ReorderableList FOJKIJGIPGN;

		// Token: 0x0400122C RID: 4652
		private RectTransform LLCHHNEHDAB;

		// Token: 0x0400122D RID: 4653
		private LayoutElement JCBPLHHNOON;

		// Token: 0x0400122E RID: 4654
		private Vector2 EJCHCCIDKAJ;

		// Token: 0x0400122F RID: 4655
		private RectTransform JMKLJAKMNKK;

		// Token: 0x04001230 RID: 4656
		private LayoutElement HBEIKFEFDDA;

		// Token: 0x04001231 RID: 4657
		private int CMLMOJNPBDP;

		// Token: 0x04001232 RID: 4658
		private bool NDGBBDKAJEN;

		// Token: 0x04001233 RID: 4659
		private RectTransform BBNGEJDDCIG;

		// Token: 0x04001234 RID: 4660
		private ReorderableList CPLNKKEKGNO;
	}
}
