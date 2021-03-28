using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002D7 RID: 727
	[AddComponentMenu("Event/VR Input Module")]
	public class VRInputModule : BaseInputModule
	{
		// Token: 0x0600AC2D RID: 44077 RVA: 0x003F9CF8 File Offset: 0x003F7EF8
		public static void EOJMJMOJKOJ(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_TimeX" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC2E RID: 44078 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void MCIEAOAMOIG()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC2F RID: 44079 RVA: 0x003F9D4C File Offset: 0x003F7F4C
		public static void HONDKJEIMLE(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_TapMedium" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC30 RID: 44080 RVA: 0x003F9D98 File Offset: 0x003F7F98
		public static void PointerEnter(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("PointerEnter " + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC31 RID: 44081 RVA: 0x003F9DFC File Offset: 0x003F7FFC
		public static void CGIDPNKFMOG(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("max. lives color" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x003F9E60 File Offset: 0x003F8060
		public static void PBJKKMPHMNJ(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("Please attach component to a Graphical UI component" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = false;
			}
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void GGKPLCJNEHF()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void AJIKPEIGACI()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC35 RID: 44085 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void HBPLJMJAAHK()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC36 RID: 44086 RVA: 0x003F9ECE File Offset: 0x003F80CE
		public virtual void NEFAMCBPNJC()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = true;
				return;
			}
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x003F9EE8 File Offset: 0x003F80E8
		public static void FLCPFEGPLFC(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("menutheme" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void DEJEBOGKMJO()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x003F9F4C File Offset: 0x003F814C
		public static void PNMEHHEBNHJ(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this." + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x003F9F98 File Offset: 0x003F8198
		public static void IAOBKKOKGIB(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("BitsData" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x003F9FFC File Offset: 0x003F81FC
		public static void INNNBCKAAMO(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("]" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void NKMJJEPJFAA()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void LHMDCEDONEE()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void BIGECCFKKOE()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x003FA078 File Offset: 0x003F8278
		public static void BJEFLIKJHDC(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("achievements.26.progress" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x003FA0E8 File Offset: 0x003F82E8
		public static void FPAOHAHKCME(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_FarCamera" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC41 RID: 44097 RVA: 0x003FA14C File Offset: 0x003F834C
		public static void FOEEIECGNNP(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("UpdateDownloadingProgress" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC42 RID: 44098 RVA: 0x003F9ECE File Offset: 0x003F80CE
		public virtual void NLIAEIMGHCE()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = true;
				return;
			}
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x003FA198 File Offset: 0x003F8398
		public static void KCOPNONNNBI(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("Ignored PU RPC, cause item is inactive. " + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = false;
			}
		}

		// Token: 0x0600AC44 RID: 44100 RVA: 0x003FA208 File Offset: 0x003F8408
		public static void JHIEJCAJDMK(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_WhiteBalance" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC45 RID: 44101 RVA: 0x003FA26C File Offset: 0x003F846C
		public static void EJLKOFBJJBO(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("LoadingStatusText" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC46 RID: 44102 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void NKGKHEPMJNO()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void ACIHPDFPHNF()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void MFAMHKBMBEI()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x003FA2DC File Offset: 0x003F84DC
		public static void ADDMMNOLDDA(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("UI/Particles/Hidden" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void OLFNCABJBHA()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x003FA328 File Offset: 0x003F8528
		public static void GNAMFFDLOML(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("Image_" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void GLIGLOCALAB()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC4D RID: 44109 RVA: 0x003FA38C File Offset: 0x003F858C
		public static void FPGACGKJIHF(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print(".png" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC4E RID: 44110 RVA: 0x003FA3D8 File Offset: 0x003F85D8
		public static void LJFOLJGOHHK(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_Parameter" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void OBGLNNKKENL()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x003FA424 File Offset: 0x003F8624
		public static void EHEGKPANAGG(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("_Value3" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = false;
			}
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x003FA494 File Offset: 0x003F8694
		public static void EBJKOOFHMEH(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("Joystick1Button8" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x003FA504 File Offset: 0x003F8704
		public static void DJOLJDIDMLA(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("intensity" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC53 RID: 44115 RVA: 0x003FA550 File Offset: 0x003F8750
		public static void PointerExit(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("PointerExit " + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void LFHKGIHNONL()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected override void Awake()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void DMIKIDGJEFC()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC57 RID: 44119 RVA: 0x003FA59C File Offset: 0x003F879C
		public static void GHLHFGONJHL(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("CameraFilterPack/Drawing_Manga_Flash_Color" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC58 RID: 44120 RVA: 0x003F9ECE File Offset: 0x003F80CE
		public virtual void FDKHJDIGGKE()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = true;
				return;
			}
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void JFJECKDIKCF()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x003FA600 File Offset: 0x003F8800
		public static void OBHDPFAGFFL(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = false;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("Connected to masterserver." + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = false;
			}
		}

		// Token: 0x0600AC5B RID: 44123 RVA: 0x003FA670 File Offset: 0x003F8870
		public static void HHNPEMDHLPK(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_WaveIntensity" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC5C RID: 44124 RVA: 0x003FA6BC File Offset: 0x003F88BC
		public static void MGBJFLLOOIP(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("[Up]" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x003FA05F File Offset: 0x003F825F
		public override void Process()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x003FA720 File Offset: 0x003F8920
		public static void FHMEJJFAOCJ(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_Value2" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC5F RID: 44127 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void OKADMJFLMGP()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC60 RID: 44128 RVA: 0x003FA76C File Offset: 0x003F896C
		public static void HNHHOPCDLCB(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_Value5" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x003FA7D0 File Offset: 0x003F89D0
		public static void LFCACFBDHLM(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("settings_bindings_controller_type" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x003FA834 File Offset: 0x003F8A34
		public static void CJODLPBNPAJ(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("settings_bindings_controller_type" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x003FA898 File Offset: 0x003F8A98
		public static void PointerSubmit(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("clicked " + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = false;
			}
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void KACPCCMPAHA()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void GIIIBJBDJAI()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void LBOBAIGNOML()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x003FA908 File Offset: 0x003F8B08
		public static void KMAGKNNGBMM(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("player.goldlollipop" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void OBPCMAFGLON()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x003F9ECE File Offset: 0x003F80CE
		public virtual void KCEGBIKLDNK()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = true;
				return;
			}
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x003FA978 File Offset: 0x003F8B78
		public static void FIFGMACEOCI(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = false;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("InfoCanvas" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC6B RID: 44139 RVA: 0x003FA9E8 File Offset: 0x003F8BE8
		public static void MHBAILEACLD(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("Vertical" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC6C RID: 44140 RVA: 0x003FAA4C File Offset: 0x003F8C4C
		public static void KEINJBDIMPM(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("[ItemsHandler] Inventory not changed" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x003FAAB0 File Offset: 0x003F8CB0
		public static void JFJNNNKBNNM(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_TimeX" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC6E RID: 44142 RVA: 0x003FAB14 File Offset: 0x003F8D14
		public static void MHCGECGFPEN(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("Subscribe: " + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x003F9ECE File Offset: 0x003F80CE
		public virtual void FNAHBMBALGL()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = true;
				return;
			}
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x003FAB60 File Offset: 0x003F8D60
		public static void ANJLIHFDPPL(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("event" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x003FABD0 File Offset: 0x003F8DD0
		public static void JAABNMCDBHI(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = false;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("_LightIntensity" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x003FAC40 File Offset: 0x003F8E40
		public static void JEOEPNHCCNB(GameObject AGPIGANJKMN)
		{
			VRInputModule.targetObject = AGPIGANJKMN;
			VRInputModule.HMOMFCNKFBO = true;
			if (VRInputModule.HMOMFCNKFBO)
			{
				BaseEventData baseEventData = new BaseEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
				baseEventData.selectedObject = VRInputModule.targetObject;
				ExecuteEvents.Execute<ISubmitHandler>(VRInputModule.targetObject, baseEventData, ExecuteEvents.submitHandler);
				MonoBehaviour.print("selector" + VRInputModule.targetObject.name);
				VRInputModule.HMOMFCNKFBO = true;
			}
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x003FACB0 File Offset: 0x003F8EB0
		public static void FADDDHONPAP(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("FileLabel" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x003FACFC File Offset: 0x003F8EFC
		public static void FLNEKDOJKLD(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("_Source" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void OAOAIIAHEJN()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x003FAD48 File Offset: 0x003F8F48
		public static void FOJJCEFEBLG(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("x" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x003FA05F File Offset: 0x003F825F
		public virtual void MMNJIFOEFFP()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = false;
				return;
			}
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x003FAD94 File Offset: 0x003F8F94
		public static void OJDCHJNHHCL(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print("CameraFilterPack/VHS_Tracking" + AGPIGANJKMN.name);
			PointerEventData eventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			ExecuteEvents.Execute<IPointerExitHandler>(AGPIGANJKMN, eventData, ExecuteEvents.pointerExitHandler);
			ExecuteEvents.Execute<IDeselectHandler>(AGPIGANJKMN, eventData, ExecuteEvents.deselectHandler);
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void FMAFBLKAJDF()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void BGFCMMDKCOI()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x003F9ECE File Offset: 0x003F80CE
		public virtual void BGIPHPNBJMF()
		{
			if (VRInputModule.targetObject == null)
			{
				VRInputModule.HMOMFCNKFBO = true;
				return;
			}
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x003FADE0 File Offset: 0x003F8FE0
		public static void NEPBELIOOKK(GameObject AGPIGANJKMN)
		{
			MonoBehaviour.print(" in-game items" + AGPIGANJKMN.name);
			PointerEventData pointerEventData = new PointerEventData(VRInputModule.AKPNCLKBMDG.eventSystem);
			pointerEventData.pointerEnter = AGPIGANJKMN;
			RaycastResult pointerCurrentRaycast = new RaycastResult
			{
				worldPosition = VRInputModule.cursorPosition
			};
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			ExecuteEvents.Execute<IPointerEnterHandler>(AGPIGANJKMN, pointerEventData, ExecuteEvents.pointerEnterHandler);
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void EIFCCFBJKOO()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void NLNAJMCBNDC()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x003F9D44 File Offset: 0x003F7F44
		protected virtual void FNMPIAMIKCP()
		{
			VRInputModule.AKPNCLKBMDG = this;
		}

		// Token: 0x04001307 RID: 4871
		public static GameObject targetObject;

		// Token: 0x04001308 RID: 4872
		private static VRInputModule AKPNCLKBMDG;

		// Token: 0x04001309 RID: 4873
		private int KNPFGJCONGO;

		// Token: 0x0400130A RID: 4874
		private static bool HMOMFCNKFBO;

		// Token: 0x0400130B RID: 4875
		public static Vector3 cursorPosition;
	}
}
