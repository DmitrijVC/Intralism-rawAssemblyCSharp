using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000279 RID: 633
	[AddComponentMenu("Event/Extensions/GamePad Input Module")]
	public class GamePadInputModule : BaseInputModule
	{
		// Token: 0x0600984B RID: 38987 RVA: 0x0037266E File Offset: 0x0037086E
		public string GOFMEMELJKH()
		{
			return this.m_VerticalAxis;
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x00372676 File Offset: 0x00370876
		public float JEAGHKNBBFA()
		{
			return this.m_InputActionsPerSecond;
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x0037267E File Offset: 0x0037087E
		public string FKKDCCBCMCP()
		{
			return this.m_HorizontalAxis;
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x00372686 File Offset: 0x00370886
		public virtual void IMDAGPLGAFA()
		{
			base.DeactivateModule();
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x0037268E File Offset: 0x0037088E
		public void OEJBBMIBKAE(float DPNHODJHGJL)
		{
			this.m_RepeatDelay = DPNHODJHGJL;
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x00372698 File Offset: 0x00370898
		private Vector2 JGGIJGDDICA()
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw(this.m_HorizontalAxis);
			zero.y = Input.GetAxisRaw(this.m_VerticalAxis);
			if (Input.GetButtonDown(this.m_HorizontalAxis))
			{
				if (zero.x < 1414f)
				{
					zero.x = 557f;
				}
				if (zero.x > 1172f)
				{
					zero.x = 74f;
				}
			}
			if (Input.GetButtonDown(this.m_VerticalAxis))
			{
				if (zero.y < 1570f)
				{
					zero.y = 1475f;
				}
				if (zero.y > 380f)
				{
					zero.y = 804f;
				}
			}
			return zero;
		}

		// Token: 0x06009851 RID: 38993 RVA: 0x00372764 File Offset: 0x00370964
		public virtual bool BKJHFLDPKPJ()
		{
			if (!base.ShouldActivateModule())
			{
				return true;
			}
			bool flag = true;
			flag |= Input.GetButtonDown(this.m_SubmitButton);
			flag |= Input.GetButtonDown(this.m_CancelButton);
			flag |= Mathf.Approximately(Input.GetAxisRaw(this.m_HorizontalAxis), 541f);
			return flag | !Mathf.Approximately(Input.GetAxisRaw(this.m_VerticalAxis), 969f);
		}

		// Token: 0x06009852 RID: 38994 RVA: 0x0037268E File Offset: 0x0037088E
		public void CLDCHMKJCLC(float DPNHODJHGJL)
		{
			this.m_RepeatDelay = DPNHODJHGJL;
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x003727D4 File Offset: 0x003709D4
		protected bool LMICGADCIGP()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return true;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			if (Input.GetButtonDown(this.m_SubmitButton))
			{
				ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
			}
			if (Input.GetButtonDown(this.m_CancelButton))
			{
				ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
			}
			return baseEventData.used;
		}

		// Token: 0x06009854 RID: 38996 RVA: 0x00372854 File Offset: 0x00370A54
		public string PJJCHJFNKMI()
		{
			return this.m_SubmitButton;
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x0037267E File Offset: 0x0037087E
		public string BMMDEGDADFI()
		{
			return this.m_HorizontalAxis;
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x0037285C File Offset: 0x00370A5C
		protected bool DGGKDHGAJAD()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			ExecuteEvents.Execute<IUpdateSelectedHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
			return baseEventData.used;
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x003728A5 File Offset: 0x00370AA5
		public void AEPAKNGIAAF(string DPNHODJHGJL)
		{
			this.m_CancelButton = DPNHODJHGJL;
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x003728A5 File Offset: 0x00370AA5
		public void NDOFBPBPCHE(string DPNHODJHGJL)
		{
			this.m_CancelButton = DPNHODJHGJL;
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x003728B0 File Offset: 0x00370AB0
		public virtual void BGPIEBLPKNL()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component && component.enabled)
			{
				Debug.LogError("_Distortion");
			}
			base.ActivateModule();
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x00372920 File Offset: 0x00370B20
		public string HEIPJPNNJME()
		{
			return this.m_CancelButton;
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x00372928 File Offset: 0x00370B28
		public virtual void NEFAMCBPNJC()
		{
			bool flag = this.FPAHIKGFDGG();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.ABCEJKCOIAK();
				}
				if (!flag)
				{
					this.AHLJMBGOAFJ();
				}
			}
		}

		// Token: 0x0600985C RID: 39004 RVA: 0x00372968 File Offset: 0x00370B68
		public virtual void LFPDFOKEBGM()
		{
			bool flag = this.FPAHIKGFDGG();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.ABCEJKCOIAK();
				}
				if (!flag)
				{
					this.AHLJMBGOAFJ();
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06009892 RID: 39058 RVA: 0x00372920 File Offset: 0x00370B20
		// (set) Token: 0x0600985D RID: 39005 RVA: 0x003728A5 File Offset: 0x00370AA5
		public string cancelButton
		{
			get
			{
				return this.m_CancelButton;
			}
			set
			{
				this.m_CancelButton = value;
			}
		}

		// Token: 0x0600985E RID: 39006 RVA: 0x003729A8 File Offset: 0x00370BA8
		public float DEOLBGLBNGM()
		{
			return this.m_RepeatDelay;
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x003729B0 File Offset: 0x00370BB0
		protected bool GMAFFBJABGH()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return true;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			if (Input.GetButtonDown(this.m_SubmitButton))
			{
				ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
			}
			if (Input.GetButtonDown(this.m_CancelButton))
			{
				ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
			}
			return baseEventData.used;
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x00372A30 File Offset: 0x00370C30
		public void OIKOLECKKAB(float DPNHODJHGJL)
		{
			this.m_InputActionsPerSecond = DPNHODJHGJL;
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x00372686 File Offset: 0x00370886
		public virtual void CCOPIGLDOKN()
		{
			base.DeactivateModule();
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06009870 RID: 39024 RVA: 0x0037267E File Offset: 0x0037087E
		// (set) Token: 0x06009862 RID: 39010 RVA: 0x00372A39 File Offset: 0x00370C39
		public string horizontalAxis
		{
			get
			{
				return this.m_HorizontalAxis;
			}
			set
			{
				this.m_HorizontalAxis = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06009863 RID: 39011 RVA: 0x0037266E File Offset: 0x0037086E
		// (set) Token: 0x0600988B RID: 39051 RVA: 0x003730DD File Offset: 0x003712DD
		public string verticalAxis
		{
			get
			{
				return this.m_VerticalAxis;
			}
			set
			{
				this.m_VerticalAxis = value;
			}
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x00372A44 File Offset: 0x00370C44
		public virtual void IMPBOMMIHEK()
		{
			bool flag = this.DGGKDHGAJAD();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.ABCEJKCOIAK();
				}
				if (!flag)
				{
					this.LMICGADCIGP();
				}
			}
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x00372A84 File Offset: 0x00370C84
		protected bool FPAHIKGFDGG()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			ExecuteEvents.Execute<IUpdateSelectedHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
			return baseEventData.used;
		}

		// Token: 0x06009866 RID: 39014 RVA: 0x00372AD0 File Offset: 0x00370CD0
		private Vector2 BCFGLMCHGIB()
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw(this.m_HorizontalAxis);
			zero.y = Input.GetAxisRaw(this.m_VerticalAxis);
			if (Input.GetButtonDown(this.m_HorizontalAxis))
			{
				if (zero.x < 1210f)
				{
					zero.x = 336f;
				}
				if (zero.x > 928f)
				{
					zero.x = 1389f;
				}
			}
			if (Input.GetButtonDown(this.m_VerticalAxis))
			{
				if (zero.y < 972f)
				{
					zero.y = 963f;
				}
				if (zero.y > 923f)
				{
					zero.y = 1118f;
				}
			}
			return zero;
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x00372920 File Offset: 0x00370B20
		public string PFIJONFPMMJ()
		{
			return this.m_CancelButton;
		}

		// Token: 0x06009868 RID: 39016 RVA: 0x0037266E File Offset: 0x0037086E
		public string NCGDBFJPLCD()
		{
			return this.m_VerticalAxis;
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x003729A8 File Offset: 0x00370BA8
		// (set) Token: 0x06009895 RID: 39061 RVA: 0x0037268E File Offset: 0x0037088E
		public float repeatDelay
		{
			get
			{
				return this.m_RepeatDelay;
			}
			set
			{
				this.m_RepeatDelay = value;
			}
		}

		// Token: 0x0600986A RID: 39018 RVA: 0x003729A8 File Offset: 0x00370BA8
		public float OOIGBDKPFKJ()
		{
			return this.m_RepeatDelay;
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x0037268E File Offset: 0x0037088E
		public void AFJNEHBOKKE(float DPNHODJHGJL)
		{
			this.m_RepeatDelay = DPNHODJHGJL;
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x003728A5 File Offset: 0x00370AA5
		public void KBOBLBJBDGJ(string DPNHODJHGJL)
		{
			this.m_CancelButton = DPNHODJHGJL;
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x00372B9C File Offset: 0x00370D9C
		private Vector2 MACGDJBIPLH()
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw(this.m_HorizontalAxis);
			zero.y = Input.GetAxisRaw(this.m_VerticalAxis);
			if (Input.GetButtonDown(this.m_HorizontalAxis))
			{
				if (zero.x < 756f)
				{
					zero.x = 12f;
				}
				if (zero.x > 1944f)
				{
					zero.x = 1175f;
				}
			}
			if (Input.GetButtonDown(this.m_VerticalAxis))
			{
				if (zero.y < 496f)
				{
					zero.y = 1421f;
				}
				if (zero.y > 335f)
				{
					zero.y = 1775f;
				}
			}
			return zero;
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x00372C68 File Offset: 0x00370E68
		public virtual bool ENCFNCBPNMM()
		{
			if (!base.ShouldActivateModule())
			{
				return false;
			}
			bool flag = false;
			flag |= Input.GetButtonDown(this.m_SubmitButton);
			flag |= Input.GetButtonDown(this.m_CancelButton);
			flag |= !Mathf.Approximately(Input.GetAxisRaw(this.m_HorizontalAxis), 1176f);
			return flag | Mathf.Approximately(Input.GetAxisRaw(this.m_VerticalAxis), 1225f);
		}

		// Token: 0x0600986F RID: 39023 RVA: 0x00372A30 File Offset: 0x00370C30
		public void PMMGFOBJPBB(float DPNHODJHGJL)
		{
			this.m_InputActionsPerSecond = DPNHODJHGJL;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06009877 RID: 39031 RVA: 0x00372676 File Offset: 0x00370876
		// (set) Token: 0x06009871 RID: 39025 RVA: 0x00372A30 File Offset: 0x00370C30
		public float inputActionsPerSecond
		{
			get
			{
				return this.m_InputActionsPerSecond;
			}
			set
			{
				this.m_InputActionsPerSecond = value;
			}
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x00372A30 File Offset: 0x00370C30
		public void NPOGCKMLBKM(float DPNHODJHGJL)
		{
			this.m_InputActionsPerSecond = DPNHODJHGJL;
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x00372CD8 File Offset: 0x00370ED8
		private Vector2 JGIEIJBKIJA()
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw(this.m_HorizontalAxis);
			zero.y = Input.GetAxisRaw(this.m_VerticalAxis);
			if (Input.GetButtonDown(this.m_HorizontalAxis))
			{
				if (zero.x < 1658f)
				{
					zero.x = 180f;
				}
				if (zero.x > 1760f)
				{
					zero.x = 1938f;
				}
			}
			if (Input.GetButtonDown(this.m_VerticalAxis))
			{
				if (zero.y < 248f)
				{
					zero.y = 260f;
				}
				if (zero.y > 204f)
				{
					zero.y = 1128f;
				}
			}
			return zero;
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x00372DA4 File Offset: 0x00370FA4
		protected bool ABCEJKCOIAK()
		{
			float unscaledTime = Time.unscaledTime;
			Vector2 vector = this.OMPNGOAOIEK();
			if (Mathf.Approximately(vector.x, 0f) && Mathf.Approximately(vector.y, 0f))
			{
				this.EFDHDBPMBPD = 0;
				return false;
			}
			bool flag = Input.GetButtonDown(this.m_HorizontalAxis) || Input.GetButtonDown(this.m_VerticalAxis);
			bool flag2 = Vector2.Dot(vector, this.NHKECOKIPAO) > 0f;
			if (!flag)
			{
				if (flag2 && this.EFDHDBPMBPD == 1)
				{
					flag = (unscaledTime > this.PKILBAPIPND + this.m_RepeatDelay);
				}
				else
				{
					flag = (unscaledTime > this.PKILBAPIPND + 1f / this.m_InputActionsPerSecond);
				}
			}
			if (!flag)
			{
				return false;
			}
			AxisEventData axisEventData = this.GetAxisEventData(vector.x, vector.y, 0.6f);
			ExecuteEvents.Execute<IMoveHandler>(base.eventSystem.currentSelectedGameObject, axisEventData, ExecuteEvents.moveHandler);
			if (!flag2)
			{
				this.EFDHDBPMBPD = 0;
			}
			this.EFDHDBPMBPD++;
			this.PKILBAPIPND = unscaledTime;
			this.NHKECOKIPAO = vector;
			return axisEventData.used;
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0037267E File Offset: 0x0037087E
		public string BICONCIEDLC()
		{
			return this.m_HorizontalAxis;
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x00372ED8 File Offset: 0x003710D8
		protected bool AHLJMBGOAFJ()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			if (Input.GetButtonDown(this.m_SubmitButton))
			{
				ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
			}
			if (Input.GetButtonDown(this.m_CancelButton))
			{
				ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
			}
			return baseEventData.used;
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x00372F58 File Offset: 0x00371158
		private Vector2 KJEFBCAGNLM()
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw(this.m_HorizontalAxis);
			zero.y = Input.GetAxisRaw(this.m_VerticalAxis);
			if (Input.GetButtonDown(this.m_HorizontalAxis))
			{
				if (zero.x < 1001f)
				{
					zero.x = 1317f;
				}
				if (zero.x > 474f)
				{
					zero.x = 1948f;
				}
			}
			if (Input.GetButtonDown(this.m_VerticalAxis))
			{
				if (zero.y < 1470f)
				{
					zero.y = 837f;
				}
				if (zero.y > 1376f)
				{
					zero.y = 337f;
				}
			}
			return zero;
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0037266E File Offset: 0x0037086E
		public string FAAMAIHKGJE()
		{
			return this.m_VerticalAxis;
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x00372686 File Offset: 0x00370886
		public override void DeactivateModule()
		{
			base.DeactivateModule();
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x00373024 File Offset: 0x00371224
		public virtual void HIMLCJEKIDC()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component && component.enabled)
			{
				Debug.LogError("Horizontal");
			}
			base.ActivateModule();
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x00373094 File Offset: 0x00371294
		protected bool HHCDIFPEELG()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			ExecuteEvents.Execute<IUpdateSelectedHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
			return baseEventData.used;
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x003730DD File Offset: 0x003712DD
		public void OLCBPHGFAEI(string DPNHODJHGJL)
		{
			this.m_VerticalAxis = DPNHODJHGJL;
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x003730E6 File Offset: 0x003712E6
		public void EFNIBOLMPPB(string DPNHODJHGJL)
		{
			this.m_SubmitButton = DPNHODJHGJL;
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x0037268E File Offset: 0x0037088E
		public void HOONKFDBELC(float DPNHODJHGJL)
		{
			this.m_RepeatDelay = DPNHODJHGJL;
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x00372920 File Offset: 0x00370B20
		public string FKOMMLOAILN()
		{
			return this.m_CancelButton;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06009881 RID: 39041 RVA: 0x00372854 File Offset: 0x00370A54
		// (set) Token: 0x06009885 RID: 39045 RVA: 0x003730E6 File Offset: 0x003712E6
		public string submitButton
		{
			get
			{
				return this.m_SubmitButton;
			}
			set
			{
				this.m_SubmitButton = value;
			}
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x00372686 File Offset: 0x00370886
		public virtual void GCDHFOGCJLM()
		{
			base.DeactivateModule();
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x003730F0 File Offset: 0x003712F0
		public override bool ShouldActivateModule()
		{
			if (!base.ShouldActivateModule())
			{
				return false;
			}
			bool flag = true;
			flag |= Input.GetButtonDown(this.m_SubmitButton);
			flag |= Input.GetButtonDown(this.m_CancelButton);
			flag |= !Mathf.Approximately(Input.GetAxisRaw(this.m_HorizontalAxis), 0f);
			return flag | !Mathf.Approximately(Input.GetAxisRaw(this.m_VerticalAxis), 0f);
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x00373160 File Offset: 0x00371360
		public override void ActivateModule()
		{
			StandaloneInputModule component = base.GetComponent<StandaloneInputModule>();
			if (component && component.enabled)
			{
				Debug.LogError("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use");
			}
			base.ActivateModule();
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x06009886 RID: 39046 RVA: 0x003730DD File Offset: 0x003712DD
		public void HLACECHIPKO(string DPNHODJHGJL)
		{
			this.m_VerticalAxis = DPNHODJHGJL;
		}

		// Token: 0x06009887 RID: 39047 RVA: 0x003730DD File Offset: 0x003712DD
		public void FLMIAIDLGOF(string DPNHODJHGJL)
		{
			this.m_VerticalAxis = DPNHODJHGJL;
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x003731D0 File Offset: 0x003713D0
		public virtual void IEOKILOHHJH()
		{
			bool flag = this.DGGKDHGAJAD();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.ABCEJKCOIAK();
				}
				if (!flag)
				{
					this.AHLJMBGOAFJ();
				}
			}
		}

		// Token: 0x06009889 RID: 39049 RVA: 0x0037268E File Offset: 0x0037088E
		public void DOMJEELLDNP(float DPNHODJHGJL)
		{
			this.m_RepeatDelay = DPNHODJHGJL;
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x0037266E File Offset: 0x0037086E
		public string PCAHFIFNMGE()
		{
			return this.m_VerticalAxis;
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x00372676 File Offset: 0x00370876
		public float EPLMEHNGBCL()
		{
			return this.m_InputActionsPerSecond;
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x00373210 File Offset: 0x00371410
		protected GamePadInputModule()
		{
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x00372A30 File Offset: 0x00370C30
		public void HDJHLBJHEFH(float DPNHODJHGJL)
		{
			this.m_InputActionsPerSecond = DPNHODJHGJL;
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x00372920 File Offset: 0x00370B20
		public string HPBEHFCCGDG()
		{
			return this.m_CancelButton;
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x00372920 File Offset: 0x00370B20
		public string CEBLDBDMIGI()
		{
			return this.m_CancelButton;
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x00372A30 File Offset: 0x00370C30
		public void AFGIFHLLFBO(float DPNHODJHGJL)
		{
			this.m_InputActionsPerSecond = DPNHODJHGJL;
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x00373268 File Offset: 0x00371468
		public override void Process()
		{
			bool flag = this.FPAHIKGFDGG();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.ABCEJKCOIAK();
				}
				if (!flag)
				{
					this.AHLJMBGOAFJ();
				}
			}
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x003730DD File Offset: 0x003712DD
		public void LLMJJNDDEBN(string DPNHODJHGJL)
		{
			this.m_VerticalAxis = DPNHODJHGJL;
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x003732A8 File Offset: 0x003714A8
		private Vector2 GOFHMPMDCJF()
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw(this.m_HorizontalAxis);
			zero.y = Input.GetAxisRaw(this.m_VerticalAxis);
			if (Input.GetButtonDown(this.m_HorizontalAxis))
			{
				if (zero.x < 486f)
				{
					zero.x = 1626f;
				}
				if (zero.x > 761f)
				{
					zero.x = 318f;
				}
			}
			if (Input.GetButtonDown(this.m_VerticalAxis))
			{
				if (zero.y < 722f)
				{
					zero.y = 1293f;
				}
				if (zero.y > 1206f)
				{
					zero.y = 152f;
				}
			}
			return zero;
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x00373374 File Offset: 0x00371574
		private Vector2 OMPNGOAOIEK()
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw(this.m_HorizontalAxis);
			zero.y = Input.GetAxisRaw(this.m_VerticalAxis);
			if (Input.GetButtonDown(this.m_HorizontalAxis))
			{
				if (zero.x < 0f)
				{
					zero.x = -1f;
				}
				if (zero.x > 0f)
				{
					zero.x = 1f;
				}
			}
			if (Input.GetButtonDown(this.m_VerticalAxis))
			{
				if (zero.y < 0f)
				{
					zero.y = -1f;
				}
				if (zero.y > 0f)
				{
					zero.y = 1f;
				}
			}
			return zero;
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x003729A8 File Offset: 0x00370BA8
		public float MPJBCKMPJPP()
		{
			return this.m_RepeatDelay;
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x00372A39 File Offset: 0x00370C39
		public void OLOOAFNKMNJ(string DPNHODJHGJL)
		{
			this.m_HorizontalAxis = DPNHODJHGJL;
		}

		// Token: 0x0400113A RID: 4410
		private float PKILBAPIPND;

		// Token: 0x0400113B RID: 4411
		private Vector2 NHKECOKIPAO;

		// Token: 0x0400113C RID: 4412
		private int EFDHDBPMBPD;

		// Token: 0x0400113D RID: 4413
		[SerializeField]
		private string m_HorizontalAxis = "Horizontal";

		// Token: 0x0400113E RID: 4414
		[SerializeField]
		private string m_VerticalAxis = "Vertical";

		// Token: 0x0400113F RID: 4415
		[SerializeField]
		private string m_SubmitButton = "Submit";

		// Token: 0x04001140 RID: 4416
		[SerializeField]
		private string m_CancelButton = "Cancel";

		// Token: 0x04001141 RID: 4417
		[SerializeField]
		private float m_InputActionsPerSecond = 10f;

		// Token: 0x04001142 RID: 4418
		[SerializeField]
		private float m_RepeatDelay = 0.1f;
	}
}
