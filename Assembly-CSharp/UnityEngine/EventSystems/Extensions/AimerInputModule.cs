using System;

namespace UnityEngine.EventSystems.Extensions
{
	// Token: 0x02000278 RID: 632
	[AddComponentMenu("Event/Extensions/Aimer Input Module")]
	[RequireComponent(typeof(EventSystem))]
	public class AimerInputModule : PointerInputModule
	{
		// Token: 0x060097B9 RID: 38841 RVA: 0x0036D240 File Offset: 0x0036B440
		public virtual void KMHIEDHOHDI()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.KOGHDMJHPFE();
			this.PKNPKJKAIIM(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x0036D290 File Offset: 0x0036B490
		public virtual void DKPDAMNDFHI()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("offline");
			}
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void HDENEPKNJNO()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x0036D2D4 File Offset: 0x0036B4D4
		protected virtual PointerEventData NECPECFGKEI()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-2, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 0.5f, (float)Screen.height * 0.5f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x0036D354 File Offset: 0x0036B554
		public virtual void DNAPHPEKPDE()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Horizontal");
			}
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x0036D38C File Offset: 0x0036B58C
		public virtual void LDHHFNKNLHN()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.ENNKOLCCMGJ();
			this.BEJCFCCEPAJ(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x0036D3DC File Offset: 0x0036B5DC
		public virtual void IOLEPIENDND()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("menu.playedpage");
			}
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x0036D414 File Offset: 0x0036B614
		public virtual void FJBBDJCMCKP()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("LevelNameInputField");
			}
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x0036D44C File Offset: 0x0036B64C
		protected virtual PointerEventData AKPHFDMLONP()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-73, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 934f, (float)Screen.height * 1935f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x0036D4CC File Offset: 0x0036B6CC
		private void BFNAKPKLJGG(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1140f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x0036D6A8 File Offset: 0x0036B8A8
		private void PLCDFEACCFP(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 638f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x0036D884 File Offset: 0x0036BA84
		public virtual void NAMGGGECPCI()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Error: I/O Failure");
			}
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x0036D8BC File Offset: 0x0036BABC
		private void BJPIFPNKHBG(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 838f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x0036DA98 File Offset: 0x0036BC98
		private void AKBJNLFMHBM(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1336f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x0036DC74 File Offset: 0x0036BE74
		protected virtual PointerEventData PKKGDKOKPID()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(90, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1522f, (float)Screen.height * 1665f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x0036DCF4 File Offset: 0x0036BEF4
		public virtual void MELEKPAMKNC()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.CMAMPPPPGNO();
			this.PLCDFEACCFP(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void LFDFNGEJJMK()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x0036DD44 File Offset: 0x0036BF44
		public virtual void OMMHBMEHBHJ()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.IHCEKEDDAEP();
			this.DLLANIHPMII(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097CB RID: 38859 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void OAMCNOMPHMG()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097CC RID: 38860 RVA: 0x0036DD94 File Offset: 0x0036BF94
		protected virtual PointerEventData JEJKANKHGCJ()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(61, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1785f, (float)Screen.height * 780f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097CD RID: 38861 RVA: 0x0036DE14 File Offset: 0x0036C014
		private void IENDJNJABNJ(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 807f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x0036DFF0 File Offset: 0x0036C1F0
		private void HPBBNJOOFBJ(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1876f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x0036E1CC File Offset: 0x0036C3CC
		private void MFINALGBLLJ(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1882f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x0036E3A8 File Offset: 0x0036C5A8
		protected virtual PointerEventData ADOAFMLJHBE()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(91, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 808f, (float)Screen.height * 325f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x0036E428 File Offset: 0x0036C628
		protected virtual PointerEventData PIPOGBPFGNF()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(50, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 576f, (float)Screen.height * 1494f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x0036E4A8 File Offset: 0x0036C6A8
		protected virtual PointerEventData CMAMPPPPGNO()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-54, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1470f, (float)Screen.height * 151f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x0036E528 File Offset: 0x0036C728
		private void IBIHNKDBODH(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 899f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void AGOAOGPMDEB()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x0036E704 File Offset: 0x0036C904
		public virtual void CPKGPLIDGDB()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.MPNFNDNJBKI();
			this.AFMKCHIGMAD(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x0036E754 File Offset: 0x0036C954
		private void OBJDDAGEKND(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1553f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097D7 RID: 38871 RVA: 0x0036E930 File Offset: 0x0036CB30
		public virtual void OOBFHFCFLHK()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Best region found in PlayerPrefs. Connecting to: ");
			}
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x0036E968 File Offset: 0x0036CB68
		protected virtual PointerEventData MDPLHPPMIJO()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(63, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 394f, (float)Screen.height * 746f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void AIDBDHLCBHL()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void HBPBNFCENCA()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x0036E9E8 File Offset: 0x0036CBE8
		public virtual void DDKAEACJAIF()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Joystick1Button0");
			}
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x0036EA20 File Offset: 0x0036CC20
		public virtual void GLIGLOCALAB()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.NMBIBKJNGNF();
			this.PLCDFEACCFP(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x0036EA70 File Offset: 0x0036CC70
		protected virtual PointerEventData AFJKHKHLOIJ()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-85, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1583f, (float)Screen.height * 1529f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x0036EAF0 File Offset: 0x0036CCF0
		public virtual void DHLDIGPKBNN()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.NMBIBKJNGNF();
			this.AEBKLLMHJCD(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x0036EB40 File Offset: 0x0036CD40
		protected virtual PointerEventData CALMKEIFBAF()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-82, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1266f, (float)Screen.height * 1858f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void NGHMLFLDGJP()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x0036EBC0 File Offset: 0x0036CDC0
		public virtual void LFPDFOKEBGM()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.ADOAFMLJHBE();
			this.OIHNHHMLHMA(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x0036EC10 File Offset: 0x0036CE10
		private void NOMHGOAFHIH(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 498f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x0036EDEC File Offset: 0x0036CFEC
		public virtual void NLIAEIMGHCE()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.MACDBBDMLED();
			this.BGOOOPEEFOI(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x0036EE3C File Offset: 0x0036D03C
		protected virtual PointerEventData IHCEKEDDAEP()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(12, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1469f, (float)Screen.height * 1309f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x0036EEBC File Offset: 0x0036D0BC
		public virtual void OEJFOAJOMDO()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("...");
			}
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x0036EEF4 File Offset: 0x0036D0F4
		protected virtual PointerEventData LOMLJGGMDLI()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(71, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1417f, (float)Screen.height * 632f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x0036EF74 File Offset: 0x0036D174
		private void OIHNHHMLHMA(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1623f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x0036F150 File Offset: 0x0036D350
		private void PKNPKJKAIIM(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 0.3f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x0036F32C File Offset: 0x0036D52C
		public virtual void NGHPOGFCMHM()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.MEBAJBHAOKH();
			this.AFMKCHIGMAD(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void KIPKLFOPMKO()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void JKHKMFINIAK()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x0036F37C File Offset: 0x0036D57C
		protected virtual PointerEventData MPNFNDNJBKI()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-34, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 321f, (float)Screen.height * 1112f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void JHHEEDJDAPD()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x0036F3FC File Offset: 0x0036D5FC
		public virtual void OKGDDECFHBL()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("maps.");
			}
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x0036F434 File Offset: 0x0036D634
		public virtual void AJAHDKFELGA()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.PIPOGBPFGNF();
			this.OBJDDAGEKND(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x0036F484 File Offset: 0x0036D684
		public virtual void MMBLJJKOIKJ()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("_Rand");
			}
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x0036F4BC File Offset: 0x0036D6BC
		private void EOIPIJCLMCH(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 472f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x0036F698 File Offset: 0x0036D898
		public virtual void AMBDKMLLKKK()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.MACDBBDMLED();
			this.FCAJJGCKAAC(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x0036F6E8 File Offset: 0x0036D8E8
		public virtual void DLANEGKFDPC()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.ENNKOLCCMGJ();
			this.NPDFHLIFEKD(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x0036F738 File Offset: 0x0036D938
		protected virtual PointerEventData JALDOMOLDFD()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-103, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 872f, (float)Screen.height * 943f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x0036F7B8 File Offset: 0x0036D9B8
		private void BEJCFCCEPAJ(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1673f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void MDOCBPBOCBJ()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x0036F994 File Offset: 0x0036DB94
		protected virtual PointerEventData AOHPPAJHBKG()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-37, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1890f, (float)Screen.height * 751f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void PMHANJLFDKB()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x0036FA14 File Offset: 0x0036DC14
		protected virtual PointerEventData NMBIBKJNGNF()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(32, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 50f, (float)Screen.height * 896f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x0036FA94 File Offset: 0x0036DC94
		public virtual void LAIANCONBAF()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("gold");
			}
		}

		// Token: 0x060097FB RID: 38907 RVA: 0x0036FACC File Offset: 0x0036DCCC
		private void DFFNFJLEJKM(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1819f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x060097FC RID: 38908 RVA: 0x0036FCA8 File Offset: 0x0036DEA8
		protected virtual PointerEventData DKAJBJNPJII()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-16, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 483f, (float)Screen.height * 293f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060097FD RID: 38909 RVA: 0x0036FD28 File Offset: 0x0036DF28
		public virtual void ACIHPDFPHNF()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.MPNFNDNJBKI();
			this.GLOFOMEPEOM(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void DHDGMEGBMIF()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x060097FF RID: 38911 RVA: 0x0036FD78 File Offset: 0x0036DF78
		private void JEILOOFKHAJ(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 336f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009800 RID: 38912 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void GMBCGHGKCLJ()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009801 RID: 38913 RVA: 0x0036FF54 File Offset: 0x0036E154
		private void DLLANIHPMII(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1272f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009802 RID: 38914 RVA: 0x00370130 File Offset: 0x0036E330
		protected virtual PointerEventData OKMILDMKLMD()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-33, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 340f, (float)Screen.height * 1786f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009803 RID: 38915 RVA: 0x003701B0 File Offset: 0x0036E3B0
		public virtual void KHOOPCNNKMH()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("MapEnd");
			}
		}

		// Token: 0x06009804 RID: 38916 RVA: 0x003701E8 File Offset: 0x0036E3E8
		public virtual void GJCNOEPCPHJ()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("PossibleMapPointsText");
			}
		}

		// Token: 0x06009805 RID: 38917 RVA: 0x00370220 File Offset: 0x0036E420
		public virtual void NAJMILKLGOP()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.NMBIBKJNGNF();
			this.IBIHNKDBODH(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x06009806 RID: 38918 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void OOJLBPHHBNF()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009807 RID: 38919 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void INBFBDFIBPG()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009808 RID: 38920 RVA: 0x00370270 File Offset: 0x0036E470
		protected virtual PointerEventData BMHPJAKDHHC()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-121, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 819f, (float)Screen.height * 205f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009809 RID: 38921 RVA: 0x003702F0 File Offset: 0x0036E4F0
		protected virtual PointerEventData KOGHDMJHPFE()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-74, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 417f, (float)Screen.height * 1577f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x0600980A RID: 38922 RVA: 0x00370370 File Offset: 0x0036E570
		public virtual void FHBBHOOCMHK()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.DKAJBJNPJII();
			this.HPBBNJOOFBJ(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x003703C0 File Offset: 0x0036E5C0
		protected virtual PointerEventData MACDBBDMLED()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-17, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 516f, (float)Screen.height * 1942f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x0600980C RID: 38924 RVA: 0x00370440 File Offset: 0x0036E640
		public virtual void ALDLGOPNDCN()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("speed");
			}
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void BANCKIADAKD()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600980E RID: 38926 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void GONLPBPCLDE()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x00370478 File Offset: 0x0036E678
		public override void ActivateModule()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
			}
		}

		// Token: 0x06009810 RID: 38928 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void COJLGGOLKKG()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009811 RID: 38929 RVA: 0x003704B0 File Offset: 0x0036E6B0
		public virtual void KDPELEHDILB()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.PIPOGBPFGNF();
			this.EOIPIJCLMCH(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x00370500 File Offset: 0x0036E700
		public virtual void JKGIBDIIHJN()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Write me to get one for testing :)");
			}
		}

		// Token: 0x06009813 RID: 38931 RVA: 0x00370538 File Offset: 0x0036E738
		public virtual void BGPIEBLPKNL()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("_ScreenResolution");
			}
		}

		// Token: 0x06009814 RID: 38932 RVA: 0x00370570 File Offset: 0x0036E770
		public virtual void CEIHOOADAMJ()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Set EnvSprite Color");
			}
		}

		// Token: 0x06009815 RID: 38933 RVA: 0x003705A8 File Offset: 0x0036E7A8
		public virtual void BKMMMLJPNGD()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.CMAMPPPPGNO();
			this.GLOFOMEPEOM(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x06009816 RID: 38934 RVA: 0x003705F8 File Offset: 0x0036E7F8
		protected virtual PointerEventData ANBIEEHEAHI()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(29, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 790f, (float)Screen.height * 1011f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x00370678 File Offset: 0x0036E878
		public virtual void INOMEKAPKCN()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("LeaderboardsButton");
			}
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x003706B0 File Offset: 0x0036E8B0
		private void NPDFHLIFEKD(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1902f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x0037088C File Offset: 0x0036EA8C
		public virtual void PHLGPPILGBA()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("#tryagain");
			}
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x003708C1 File Offset: 0x0036EAC1
		protected AimerInputModule()
		{
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x003708EC File Offset: 0x0036EAEC
		public virtual void CGNPEDPKAEH()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError(" ");
			}
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x00370924 File Offset: 0x0036EB24
		private void FAIGFPOBGHC(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1940f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void HCBCCBCDKAB()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x00370B00 File Offset: 0x0036ED00
		public virtual void DPHBIBEIPPB()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.ANBIEEHEAHI();
			this.EIPILDIPBMC(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x00370B50 File Offset: 0x0036ED50
		private void FCAJJGCKAAC(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1715f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x00370D2C File Offset: 0x0036EF2C
		public virtual void KCMFNNPDNMH()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/");
			}
		}

		// Token: 0x06009821 RID: 38945 RVA: 0x00370D64 File Offset: 0x0036EF64
		public virtual void GMBHICJAJED()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("ReJoinRoom failed due to offline mode.");
			}
		}

		// Token: 0x06009822 RID: 38946 RVA: 0x00370D9C File Offset: 0x0036EF9C
		public virtual void CLGGOFOLEEH()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.JALDOMOLDFD();
			this.DLLANIHPMII(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void GHEBMPHILFC()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x00370DEC File Offset: 0x0036EFEC
		private void IBFOBIDJGFA(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 743f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x00370FC8 File Offset: 0x0036F1C8
		public virtual void OAOAIIAHEJN()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.IAPAEOAPNBH();
			this.IBIHNKDBODH(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x00371018 File Offset: 0x0036F218
		protected virtual PointerEventData PBCNJOKGDII()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(106, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 677f, (float)Screen.height * 920f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x00371098 File Offset: 0x0036F298
		public virtual void GKPFPGHMDJH()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.ADOAFMLJHBE();
			this.IBFOBIDJGFA(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x003710E8 File Offset: 0x0036F2E8
		public virtual void HBDEDBHKHGD()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("PhotonMono");
			}
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public override void DeactivateModule()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600982A RID: 38954 RVA: 0x00371120 File Offset: 0x0036F320
		private void AFMKCHIGMAD(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1943f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void BDDBMNKAOPE()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x003712FC File Offset: 0x0036F4FC
		public virtual void IEOKILOHHJH()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.KOGHDMJHPFE();
			this.NPDFHLIFEKD(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x0037134C File Offset: 0x0036F54C
		protected virtual PointerEventData EOKBKJPEGNM()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-79, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 450f, (float)Screen.height * 1930f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void DEAIOPDJAEH()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x003713CC File Offset: 0x0036F5CC
		protected virtual PointerEventData FEOJINKGEPC()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-95, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 149f, (float)Screen.height * 207f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009830 RID: 38960 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void IJCFONDPPGL()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x0037144C File Offset: 0x0036F64C
		private void EIPILDIPBMC(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 191f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x00371628 File Offset: 0x0036F828
		private void GLOFOMEPEOM(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 159f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void IMCCHEDCKBN()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009834 RID: 38964 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void NLENBPFJCCO()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void NLLKMNJHKIJ()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x00371804 File Offset: 0x0036FA04
		public virtual void GFMNJLJJMOO()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("/");
			}
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void BHAIBPKKKEH()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06009838 RID: 38968 RVA: 0x0037183C File Offset: 0x0036FA3C
		protected virtual PointerEventData NHLCMBNPLKB()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-80, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1285f, (float)Screen.height * 1039f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x003718BC File Offset: 0x0036FABC
		public virtual void JPCCENHKODC()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.FEOJINKGEPC();
			this.BFNAKPKLJGG(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x0037190C File Offset: 0x0036FB0C
		public virtual void IPDKDELKCMI()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("_Intensity");
			}
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x00371944 File Offset: 0x0036FB44
		private void FIOBJLEMCOA(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 737f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x00371B20 File Offset: 0x0036FD20
		private void LBPKPJFBIBN(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1489f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x0600983D RID: 38973 RVA: 0x00371CFC File Offset: 0x0036FEFC
		public virtual void PKNICANKFGM()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.NECPECFGKEI();
			this.PKNPKJKAIIM(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x0600983E RID: 38974 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public virtual void JBPGGMKPGFG()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600983F RID: 38975 RVA: 0x00371D4C File Offset: 0x0036FF4C
		public virtual void ALLNCPJBMLB()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("Cant send PickupItem spawn times to unknown targetPlayer.");
			}
		}

		// Token: 0x06009840 RID: 38976 RVA: 0x00371D84 File Offset: 0x0036FF84
		protected virtual PointerEventData FKPDECKAPOL()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-119, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 492f, (float)Screen.height * 209f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009841 RID: 38977 RVA: 0x00371E04 File Offset: 0x00370004
		private void FODHHCPKBPM(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 0;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1406f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009842 RID: 38978 RVA: 0x00371FE0 File Offset: 0x003701E0
		protected virtual PointerEventData IAPAEOAPNBH()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-119, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1555f, (float)Screen.height * 536f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x00372060 File Offset: 0x00370260
		protected virtual PointerEventData MEBAJBHAOKH()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(5, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 227f, (float)Screen.height * 654f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009844 RID: 38980 RVA: 0x003720E0 File Offset: 0x003702E0
		private void BGOOOPEEFOI(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = true;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = false;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 1011f)
					{
						OGOHNMALIMD.clickCount++;
					}
					else
					{
						OGOHNMALIMD.clickCount = 1;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009845 RID: 38981 RVA: 0x003722BC File Offset: 0x003704BC
		protected virtual PointerEventData ENNKOLCCMGJ()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-77, out pointerEventData, false);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1328f, (float)Screen.height * 154f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009846 RID: 38982 RVA: 0x0037233C File Offset: 0x0037053C
		protected virtual PointerEventData EAAFACMAIHG()
		{
			PointerEventData pointerEventData;
			base.GetPointerData(-106, out pointerEventData, true);
			pointerEventData.Reset();
			pointerEventData.position = new Vector2((float)Screen.width * 1415f, (float)Screen.height * 1211f) + this.aimerOffset;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x003723BC File Offset: 0x003705BC
		private void AEBKLLMHJCD(PointerEventData OGOHNMALIMD, bool PLIDFJHNCCM, bool OHGHNMFLAKE)
		{
			GameObject gameObject = OGOHNMALIMD.pointerCurrentRaycast.gameObject;
			AimerInputModule.objectUnderAimer = ExecuteEvents.GetEventHandler<ISubmitHandler>(gameObject);
			if (PLIDFJHNCCM)
			{
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.delta = Vector2.zero;
				OGOHNMALIMD.pressPosition = OGOHNMALIMD.position;
				OGOHNMALIMD.pointerPressRaycast = OGOHNMALIMD.pointerCurrentRaycast;
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<ISubmitHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.submitHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.pointerDownHandler);
					if (gameObject2 == null)
					{
						gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
					}
				}
				else
				{
					OGOHNMALIMD.eligibleForClick = true;
				}
				if (gameObject2 != OGOHNMALIMD.pointerPress)
				{
					OGOHNMALIMD.pointerPress = gameObject2;
					OGOHNMALIMD.rawPointerPress = gameObject;
					OGOHNMALIMD.clickCount = 1;
				}
				OGOHNMALIMD.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IBeginDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.beginDragHandler);
				}
			}
			if (OHGHNMFLAKE)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (OGOHNMALIMD.pointerPress == eventHandler && OGOHNMALIMD.eligibleForClick)
				{
					float unscaledTime = Time.unscaledTime;
					if (unscaledTime - OGOHNMALIMD.clickTime < 542f)
					{
						OGOHNMALIMD.clickCount += 0;
					}
					else
					{
						OGOHNMALIMD.clickCount = 0;
					}
					OGOHNMALIMD.clickTime = unscaledTime;
					ExecuteEvents.Execute<IPointerClickHandler>(OGOHNMALIMD.pointerPress, OGOHNMALIMD, ExecuteEvents.pointerClickHandler);
				}
				else if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, OGOHNMALIMD, ExecuteEvents.dropHandler);
				}
				OGOHNMALIMD.eligibleForClick = false;
				OGOHNMALIMD.pointerPress = null;
				OGOHNMALIMD.rawPointerPress = null;
				if (OGOHNMALIMD.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(OGOHNMALIMD.pointerDrag, OGOHNMALIMD, ExecuteEvents.endDragHandler);
				}
				OGOHNMALIMD.pointerDrag = null;
			}
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x00372598 File Offset: 0x00370798
		public virtual void EEHLOIMPKKD()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component != null && component.enabled)
			{
				Debug.LogError("_Value4");
			}
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x003725D0 File Offset: 0x003707D0
		public virtual void GIJIBKENMDH()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.IAPAEOAPNBH();
			this.OIHNHHMLHMA(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x00372620 File Offset: 0x00370820
		public override void Process()
		{
			bool buttonDown = Input.GetButtonDown(this.activateAxis);
			bool buttonUp = Input.GetButtonUp(this.activateAxis);
			PointerEventData pointerEventData = this.NECPECFGKEI();
			this.PKNPKJKAIIM(pointerEventData, buttonDown, buttonUp);
			if (!buttonUp)
			{
				this.ProcessMove(pointerEventData);
			}
			else
			{
				base.RemovePointerData(pointerEventData);
			}
		}

		// Token: 0x04001137 RID: 4407
		public string activateAxis = "Submit";

		// Token: 0x04001138 RID: 4408
		public Vector2 aimerOffset = new Vector2(0f, 0f);

		// Token: 0x04001139 RID: 4409
		public static GameObject objectUnderAimer;
	}
}
