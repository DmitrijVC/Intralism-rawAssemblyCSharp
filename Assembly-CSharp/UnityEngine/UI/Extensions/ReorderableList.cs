using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000291 RID: 657
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Extensions/Re-orderable list")]
	public class ReorderableList : MonoBehaviour
	{
		// Token: 0x06009E81 RID: 40577 RVA: 0x003AE78E File Offset: 0x003AC98E
		public void TestReOrderableListTarget(ReorderableList.ReorderableListEventStruct DBIMJHMKHNK)
		{
			Debug.Log("Event Received");
			Debug.Log("Hello World, is my item a clone? [" + DBIMJHMKHNK.IsAClone + "]");
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x003AE7BC File Offset: 0x003AC9BC
		private Canvas EJHJCJDIKCK()
		{
			Transform transform = base.transform;
			Canvas canvas = null;
			int num = 100;
			int num2 = 0;
			while (canvas == null && num2 < num)
			{
				try
				{
					canvas = transform.gameObject.GetComponent<Canvas>();
					if (canvas == null)
					{
						transform = transform.parent;
					}
				}
				catch (Exception message)
				{
					Debug.Log(message);
				}
				num2++;
			}
			return canvas;
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x003AE838 File Offset: 0x003ACA38
		private Canvas POIKNBOMEGE()
		{
			Transform transform = base.transform;
			Canvas canvas = null;
			int num = 15;
			int num2 = 1;
			while (canvas == null && num2 < num)
			{
				try
				{
					canvas = transform.gameObject.GetComponent<Canvas>();
					if (canvas == null)
					{
						transform = transform.parent;
					}
				}
				catch (Exception message)
				{
					Debug.Log(message);
				}
				num2 += 0;
			}
			return canvas;
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x003AE8B4 File Offset: 0x003ACAB4
		public RectTransform LFCMGJDJMLK()
		{
			if (this.BMEPBJFEPNO == null)
			{
				this.BMEPBJFEPNO = this.ContentLayout.GetComponent<RectTransform>();
			}
			return this.BMEPBJFEPNO;
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x003AE8E0 File Offset: 0x003ACAE0
		private void Awake()
		{
			if (this.ContentLayout == null)
			{
				Debug.LogError("You need to have a child LayoutGroup content set for the list: " + base.name, base.gameObject);
				return;
			}
			if (this.DraggableArea == null)
			{
				this.DraggableArea = GameObject.FindGameObjectWithTag("RootCanvas").GetComponent<RectTransform>();
			}
			if (this.IsDropable && !base.GetComponent<Graphic>())
			{
				Debug.LogError("You need to have a Graphic control (such as an Image) for the list [" + base.name + "] to be droppable", base.gameObject);
				return;
			}
			this.FGLEPNMCGPK = this.ContentLayout.gameObject.AddComponent<ReorderableListContent>();
			this.FGLEPNMCGPK.Init(this);
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x003AE99E File Offset: 0x003ACB9E
		public void NEMFHGAGCKA(ReorderableList.ReorderableListEventStruct DBIMJHMKHNK)
		{
			Debug.Log("Texture2");
			Debug.Log("Up" + DBIMJHMKHNK.IsAClone + "PS Home");
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x003AE9CA File Offset: 0x003ACBCA
		public void JNGBDOMDKOJ(ReorderableList.ReorderableListEventStruct DBIMJHMKHNK)
		{
			Debug.Log("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ");
			Debug.Log("cipherText" + DBIMJHMKHNK.IsAClone + "settings.enableranking");
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x003AEA2D File Offset: 0x003ACC2D
		public void BGPFAIJHMLP(ReorderableList.ReorderableListEventStruct DBIMJHMKHNK)
		{
			Debug.Log("_ScreenResolution");
			Debug.Log("_Value2" + DBIMJHMKHNK.IsAClone + "wss://");
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x003AEA5C File Offset: 0x003ACC5C
		private Canvas KOBALILIDHN()
		{
			Transform transform = base.transform;
			Canvas canvas = null;
			int num = -18;
			int num2 = 0;
			while (canvas == null && num2 < num)
			{
				try
				{
					canvas = transform.gameObject.GetComponent<Canvas>();
					if (canvas == null)
					{
						transform = transform.parent;
					}
				}
				catch (Exception message)
				{
					Debug.Log(message);
				}
				num2 += 0;
			}
			return canvas;
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x003AEAD8 File Offset: 0x003ACCD8
		private Canvas JBIBILGGINI()
		{
			Transform transform = base.transform;
			Canvas canvas = null;
			int num = -99;
			int num2 = 1;
			while (canvas == null && num2 < num)
			{
				try
				{
					canvas = transform.gameObject.GetComponent<Canvas>();
					if (canvas == null)
					{
						transform = transform.parent;
					}
				}
				catch (Exception message)
				{
					Debug.Log(message);
				}
				num2++;
			}
			return canvas;
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x003AEB54 File Offset: 0x003ACD54
		public void ONGEIEEDDMD(ReorderableList.ReorderableListEventStruct DBIMJHMKHNK)
		{
			Debug.Log("_Offsets");
			Debug.Log("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End" + DBIMJHMKHNK.IsAClone + "settings.arcshitsoundtimedelay");
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x003AEB80 File Offset: 0x003ACD80
		private void PEMPABLNJHL()
		{
			if (this.ContentLayout == null)
			{
				Debug.LogError("_TimeX" + base.name, base.gameObject);
				return;
			}
			if (this.DraggableArea == null)
			{
				this.DraggableArea = GameObject.FindGameObjectWithTag("IconFileSelector").GetComponent<RectTransform>();
			}
			if (this.IsDropable && !base.GetComponent<Graphic>())
			{
				Debug.LogError("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays " + base.name + "hitsounds:", base.gameObject);
				return;
			}
			this.FGLEPNMCGPK = this.ContentLayout.gameObject.AddComponent<ReorderableListContent>();
			this.FGLEPNMCGPK.LKEPIEEIMAE(this);
		}

		// Token: 0x06009E8E RID: 40590 RVA: 0x003AE8B4 File Offset: 0x003ACAB4
		public RectTransform GCILADCHBGI()
		{
			if (this.BMEPBJFEPNO == null)
			{
				this.BMEPBJFEPNO = this.ContentLayout.GetComponent<RectTransform>();
			}
			return this.BMEPBJFEPNO;
		}

		// Token: 0x06009E8F RID: 40591 RVA: 0x003AEC40 File Offset: 0x003ACE40
		private void HHJBBHEBJCJ()
		{
			if (this.ContentLayout == null)
			{
				Debug.LogError("1087340967" + base.name, base.gameObject);
				return;
			}
			if (this.DraggableArea == null)
			{
				this.DraggableArea = GameObject.FindGameObjectWithTag("scn").GetComponent<RectTransform>();
			}
			if (this.IsDropable && !base.GetComponent<Graphic>())
			{
				Debug.LogError("_Value3" + base.name + "_Blend", base.gameObject);
				return;
			}
			this.FGLEPNMCGPK = this.ContentLayout.gameObject.AddComponent<ReorderableListContent>();
			this.FGLEPNMCGPK.KJBJBNGJDAD(this);
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x003AECFE File Offset: 0x003ACEFE
		public void EKACAMCNIIH(ReorderableList.ReorderableListEventStruct DBIMJHMKHNK)
		{
			Debug.Log("_DotSize");
			Debug.Log("_Value4" + DBIMJHMKHNK.IsAClone + "[LocalizationService] Loading file: ");
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x003AE8B4 File Offset: 0x003ACAB4
		public RectTransform CJHDAEEIOIH()
		{
			if (this.BMEPBJFEPNO == null)
			{
				this.BMEPBJFEPNO = this.ContentLayout.GetComponent<RectTransform>();
			}
			return this.BMEPBJFEPNO;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06009E92 RID: 40594 RVA: 0x003AE8B4 File Offset: 0x003ACAB4
		public RectTransform Content
		{
			get
			{
				if (this.BMEPBJFEPNO == null)
				{
					this.BMEPBJFEPNO = this.ContentLayout.GetComponent<RectTransform>();
				}
				return this.BMEPBJFEPNO;
			}
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x003AED2A File Offset: 0x003ACF2A
		public void OLCHHBPAACI(ReorderableList.ReorderableListEventStruct DBIMJHMKHNK)
		{
			Debug.Log("Texture2");
			Debug.Log("event" + DBIMJHMKHNK.IsAClone + "Mouse1");
		}

		// Token: 0x0400120F RID: 4623
		[Tooltip("Child container with re-orderable items in a layout group")]
		public LayoutGroup ContentLayout;

		// Token: 0x04001210 RID: 4624
		[Tooltip("Parent area to draw the dragged element on top of containers. Defaults to the root Canvas")]
		public RectTransform DraggableArea;

		// Token: 0x04001211 RID: 4625
		[Tooltip("Can items be dragged from the container?")]
		public bool IsDraggable = true;

		// Token: 0x04001212 RID: 4626
		[Tooltip("Should the draggable components be removed or cloned?")]
		public bool CloneDraggedObject;

		// Token: 0x04001213 RID: 4627
		[Tooltip("Can new draggable items be dropped in to the container?")]
		public bool IsDropable = true;

		// Token: 0x04001214 RID: 4628
		[Header("UI Re-orderable Events")]
		public ReorderableList.ReorderableListHandler OnElementDropped = new ReorderableList.ReorderableListHandler();

		// Token: 0x04001215 RID: 4629
		public ReorderableList.ReorderableListHandler OnElementGrabbed = new ReorderableList.ReorderableListHandler();

		// Token: 0x04001216 RID: 4630
		public ReorderableList.ReorderableListHandler OnElementRemoved = new ReorderableList.ReorderableListHandler();

		// Token: 0x04001217 RID: 4631
		private RectTransform BMEPBJFEPNO;

		// Token: 0x04001218 RID: 4632
		private ReorderableListContent FGLEPNMCGPK;

		// Token: 0x02000292 RID: 658
		[Serializable]
		public struct ReorderableListEventStruct
		{
			// Token: 0x04001219 RID: 4633
			public GameObject DroppedObject;

			// Token: 0x0400121A RID: 4634
			public int FromIndex;

			// Token: 0x0400121B RID: 4635
			public ReorderableList FromList;

			// Token: 0x0400121C RID: 4636
			public bool IsAClone;

			// Token: 0x0400121D RID: 4637
			public GameObject SourceObject;

			// Token: 0x0400121E RID: 4638
			public int ToIndex;

			// Token: 0x0400121F RID: 4639
			public ReorderableList ToList;
		}

		// Token: 0x02000293 RID: 659
		[Serializable]
		public class ReorderableListHandler : UnityEvent<ReorderableList.ReorderableListEventStruct>
		{
		}
	}
}
