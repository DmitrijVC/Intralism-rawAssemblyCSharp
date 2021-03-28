using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x02000397 RID: 919
public class CustomEventEditor : MonoBehaviour
{
	// Token: 0x0600CD18 RID: 52504 RVA: 0x0049BF54 File Offset: 0x0049A154
	public virtual void OAGNIIAKADE()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.OPAOBFHDFEF() + "CameraFilterPack/Distortion_FishEye";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD19 RID: 52505 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void CCCBAKHEAPK()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD1A RID: 52506 RVA: 0x0049BFE8 File Offset: 0x0049A1E8
	public virtual void JMKNDFJMMBJ()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.KDDBDAAEALD() + "SetParticlesInput";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.ELOBPADDKGE();
	}

	// Token: 0x0600CD1B RID: 52507 RVA: 0x0049C08C File Offset: 0x0049A28C
	public virtual void CMIMDMBHNGK()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.NIFGEHJGJDO() + "_TimeX";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.DDPPHDJFKOF();
	}

	// Token: 0x0600CD1C RID: 52508 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void JDFHNDIIJNA()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD1D RID: 52509 RVA: 0x0049C130 File Offset: 0x0049A330
	public virtual void BDEMGBNCCCP()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.PBICFJPONKP() + "_History2ChromaTex";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD1E RID: 52510 RVA: 0x0049C1BC File Offset: 0x0049A3BC
	public void FMFPLOKHPNI(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.ClearSelection();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.NELLMKOMNDF));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_TimeX"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1327f, 511f, 884f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 2;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_Distance"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(964f, 1642f, 733f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "outputitemdefid";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_EmissionColor" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(762f, 1489f, 3f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[1];
					char[] array = new char[0];
					array[1] = (char)-104;
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[1];
						char[] array2 = new char[1];
						array2[1] = '\u0013';
						component.LHAENMGOBMM(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().ALGKENJGNLL(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("/"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1911f, 473f, 1508f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find(" not exist").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.JDELIMPGFDJ)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component2.EINGDNGIEMO(0, false);
			component2.FCGCEPPJNMM();
			component2.KCDJGHLPBMG();
			component2.MMFBPCJPION(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.LLGBONGFMBH))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_TimeX").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD1F RID: 52511 RVA: 0x0049C6AC File Offset: 0x0049A8AC
	public void DLMGFPOJPJO()
	{
		this.isEditing = false;
	}

	// Token: 0x0600CD20 RID: 52512 RVA: 0x0049C6B8 File Offset: 0x0049A8B8
	public void DGNMPBOCIME(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.MCCBKCDPIMK();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.NLKHGEDKLCA));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_TimeX"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1842f, 505f, 576f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 4;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Fade"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(398f, 525f, 853f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "CameraFilterPack/Atmosphere_Rain_Pro";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("SpawnObj" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(472f, 11f, 1468f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					if (this.AKDDCMDKLED.mapEvent.data[0].Split(new char[]
					{
						(char)-33
					})[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text = this.AKDDCMDKLED.mapEvent.data[1];
						char[] array = new char[1];
						array[1] = (char)-121;
						component.LCGMHCBNCDM(text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().IKLAFGHCELK(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Left"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(966f, 1540f, 374f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.Init && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("reset").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.GBKBDKHPLKG)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component2.ABEFJKAGJBG(0, true);
			component2.FCGCEPPJNMM();
			component2.EBBKKKHMJBM();
			component2.PGCCCGLPAGK(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.LGKMMLGKBEF))), true);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find(" not exist").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD21 RID: 52513 RVA: 0x0049CBA8 File Offset: 0x0049ADA8
	public void PBFGHGJDBFH()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Value6").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.OFHCGKJFGDI)).ToList<EditorEventFunctionInfo>();
			this.JDIHOFAKNGG(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.BOPKCHEPEEB)).id, null);
		}
	}

	// Token: 0x0600CD22 RID: 52514 RVA: 0x0049CC58 File Offset: 0x0049AE58
	private bool NLKHGEDKLCA(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.DOOGPJDDJDJ;
	}

	// Token: 0x0600CD23 RID: 52515 RVA: 0x0049CC6C File Offset: 0x0049AE6C
	public void HIHHPDGKCPE(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.DLHMKKOKJPE();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.LMEOHKPCHJJ));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("settings.arcsdestroydelay"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1359f, 1989f, 1702f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize++;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_MaxRadiusOrKInPaper"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(712f, 701f, 501f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "workshop.";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("PUNCloudBestRegion" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(315f, 1480f, 122f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					if (this.AKDDCMDKLED.mapEvent.data[1].Split(new char[]
					{
						(char)-13
					})[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text = this.AKDDCMDKLED.mapEvent.data[0];
						char[] array = new char[1];
						array[1] = (char)-109;
						component.Init(text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().EBMNMBNJDMK(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("0"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(1988f, 55f, 1304f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.Init && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("event").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.PIJAOCFAPKC)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, true, null));
			}
			component2.MMFBPCJPION(0, false);
			component2.CMPLIHAOKOA();
			component2.PPKOKKBMHJC();
			component2.EOPLNNDKJLM(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.PHGILLBNBME))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("?").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD24 RID: 52516 RVA: 0x0049D15C File Offset: 0x0049B35C
	public void PEEAFFNCLJO(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.ELOBPADDKGE();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.JGCAPEAJPLO));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_ScreenResolution"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(719f, 1017f, 106f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 4;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("icon"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1675f, 1007f, 1768f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "_BlurCoe";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("HitVariationSlider" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(265f, 858f, 180f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[0];
					char[] array = new char[1];
					array[1] = 'e';
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[1];
						char[] array2 = new char[1];
						array2[1] = (char)-59;
						component.PJILLPKFCPO(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().LMHFEBCKPDI(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_MainTex2"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1211f, 844f, 324f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find(" registered.").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.PIJAOCFAPKC)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, true, null));
			}
			component2.EINGDNGIEMO(0, true);
			component2.KBAJMMDNILB();
			component2.PPKOKKBMHJC();
			component2.HKJDGOCIGEB(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.HMMBBDJNGGL))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_ScreenResolution").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD25 RID: 52517 RVA: 0x0049D64C File Offset: 0x0049B84C
	public void IAADPNABCFE()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("getbool").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.INHOEMCLAAP)).ToList<EditorEventFunctionInfo>();
			this.JDIHOFAKNGG(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.ECGDAHDOPBO)).id, null);
		}
	}

	// Token: 0x0600CD26 RID: 52518 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void ALNNIDLFILB()
	{
	}

	// Token: 0x0600CD27 RID: 52519 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void JHANGPCOCIG()
	{
	}

	// Token: 0x0600CD28 RID: 52520 RVA: 0x0049CC58 File Offset: 0x0049AE58
	[CompilerGenerated]
	private bool LMEOHKPCHJJ(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.DOOGPJDDJDJ;
	}

	// Token: 0x0600CD29 RID: 52521 RVA: 0x0049D6FC File Offset: 0x0049B8FC
	public virtual void PasteEvent()
	{
		if (this.AKDDCMDKLED)
		{
			Debug.Log("Editing: " + this.AKDDCMDKLED.mapEvent);
			this.AKDDCMDKLED.mapEvent.data = this.PNIJCGEOHIM;
			this.DOOGPJDDJDJ = this.AKDDCMDKLED.mapEvent.data[0];
			this.RebuildEditor(true);
		}
	}

	// Token: 0x0600CD2A RID: 52522 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void PNLKFANNOKO()
	{
	}

	// Token: 0x0600CD2B RID: 52523 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void GIPHFANNABM()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD2C RID: 52524 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void ILCFPCIPENO()
	{
	}

	// Token: 0x0600CD2D RID: 52525 RVA: 0x0049D76C File Offset: 0x0049B96C
	public virtual void IFIOEHIBPGM(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.MGBGMAAJHJK(true);
		}
	}

	// Token: 0x0600CD2E RID: 52526 RVA: 0x0049D7A0 File Offset: 0x0049B9A0
	public virtual void PGCBIFKKBKE()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.BJJHICBDIJJ() + "workshop.";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD2F RID: 52527 RVA: 0x0049D829 File Offset: 0x0049BA29
	public void FDCDIOJJKOM(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.FMFPLOKHPNI(false);
		}
	}

	// Token: 0x0600CD30 RID: 52528 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void PDHKMDBNGGN()
	{
	}

	// Token: 0x0600CD31 RID: 52529 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void KAPJLILNGAE()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD32 RID: 52530 RVA: 0x0049CC58 File Offset: 0x0049AE58
	private bool NELLMKOMNDF(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.DOOGPJDDJDJ;
	}

	// Token: 0x0600CD33 RID: 52531 RVA: 0x0049D84A File Offset: 0x0049BA4A
	public virtual void MKCBFNCOCHK(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.IILCEDCGAEN(false);
		}
	}

	// Token: 0x0600CD34 RID: 52532 RVA: 0x0049D87C File Offset: 0x0049BA7C
	public void MHOAJMPLKJO(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.NIKKNNEKHPF(false);
		}
	}

	// Token: 0x0600CD35 RID: 52533 RVA: 0x0049D8A0 File Offset: 0x0049BAA0
	public virtual void JBHHBKDJPJO()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.FPBDGKKPPAE() + "maps.";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.ELOBPADDKGE();
	}

	// Token: 0x0600CD36 RID: 52534 RVA: 0x0049D944 File Offset: 0x0049BB44
	public virtual void AKECKMHPOCO()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.NDLGNGFGBEA() + "_Offsets";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD37 RID: 52535 RVA: 0x0049D9D0 File Offset: 0x0049BBD0
	public void HDFIPMGMGOB(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.OFEBBEDPNJP();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.LMEOHKPCHJJ));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("#discord{0}joinrequest"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(974f, 143f, 1602f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize++;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("player.watermelon"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(1438f, 810f, 853f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "_TimeX";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("shaders" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1648f, 157f, 1359f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[1];
					char[] array = new char[0];
					array[0] = ' ';
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[1];
						char[] array2 = new char[0];
						array2[1] = (char)-115;
						component.GCGIMJEIKHM(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().BFMEBNFGCEA(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits."), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(23f, 502f, 1418f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.Init && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("/").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.AEINPAGJFME)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component2.EINGDNGIEMO(1, true);
			component2.FKPPDOHCLGA();
			component2.RedrawPanel();
			component2.MHDILMGABCK(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.HCFLGKJFKFE))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Value3").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD38 RID: 52536 RVA: 0x0049C6AC File Offset: 0x0049A8AC
	public void StopEditing()
	{
		this.isEditing = false;
	}

	// Token: 0x0600CD39 RID: 52537 RVA: 0x0049C6AC File Offset: 0x0049A8AC
	public void NOGGIDKKJHP()
	{
		this.isEditing = false;
	}

	// Token: 0x0600CD3A RID: 52538 RVA: 0x0049DEC0 File Offset: 0x0049C0C0
	public virtual void ALDLOAHENFF()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.JFLIFMAKPOA() + "_TimeX";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.NJDJHMPAIFE();
		Singleton<UI>.Instance.MCCBKCDPIMK();
	}

	// Token: 0x0600CD3B RID: 52539 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void StartEditing()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD3C RID: 52540 RVA: 0x0049CC58 File Offset: 0x0049AE58
	private bool MGKOFFFHDBG(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.DOOGPJDDJDJ;
	}

	// Token: 0x0600CD3D RID: 52541 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void IJMPCIMKFHF()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD3E RID: 52542 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void DBEMDAJDDDA()
	{
	}

	// Token: 0x0600CD3F RID: 52543 RVA: 0x0049DF64 File Offset: 0x0049C164
	public void IILCEDCGAEN(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.PNGLBLFJOOJ();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.LMEOHKPCHJJ));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("|"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(847f, 1587f, 484f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 4;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_TimeX"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1917f, 834f, 500f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + " id: ";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_TimeX" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1063f, 1288f, 518f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[0];
					char[] array = new char[0];
					array[1] = (char)-54;
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[0];
						char[] array2 = new char[1];
						array2[1] = (char)-57;
						component.FFBDGOBNNCO(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().Init(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Dance"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(294f, 29f, 1291f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Value4").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.LNDGINDKPFA)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component2.MHDILMGABCK(0, true);
			component2.FKPPDOHCLGA();
			component2.MEMKGENEOGJ();
			component2.HKJDGOCIGEB(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.HNMFCOHLALO))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("mapselector.filter.officialsortmode").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD40 RID: 52544 RVA: 0x0049E454 File Offset: 0x0049C654
	public virtual void HIKBJIPGJKO()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.PFDIKHPAKLE() + "_Value";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.DDPPHDJFKOF();
	}

	// Token: 0x0600CD41 RID: 52545 RVA: 0x0049E4F6 File Offset: 0x0049C6F6
	public void JDLBMFDFCEO(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.HFDKLFLMAHH(true);
		}
	}

	// Token: 0x0600CD42 RID: 52546 RVA: 0x0049E518 File Offset: 0x0049C718
	public void DINAGBNGBNO(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.GGIFLKMELMP();
		GameObject gameObject = this.content;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.NELLMKOMNDF));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_ScreenResolution"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(898f, 1415f, 1068f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 6;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelConfigButton"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1310f, 407f, 631f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "#loopnumber ";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("[MapsData] User's maps was loaded" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1509f, 1057f, 1091f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					if (this.AKDDCMDKLED.mapEvent.data[1].Split(new char[]
					{
						'4'
					})[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text = this.AKDDCMDKLED.mapEvent.data[1];
						char[] array = new char[0];
						array[0] = (char)-35;
						component.PIEPPKMBJHI(text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().LHAENMGOBMM(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("https://bitbucket.org/khb-soft/intralismarcsviewer/"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(37f, 1778f, 1316f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Intensity").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.FFEGPHJKMFK)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, true, null));
			}
			component2.EINGDNGIEMO(0, false);
			component2.RebuildPanel();
			component2.EBBKKKHMJBM();
			component2.MMFBPCJPION(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.JPICHJKIMDH))), true);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_TapLowBackground").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD43 RID: 52547 RVA: 0x0049EA08 File Offset: 0x0049CC08
	public void RebuildEditor(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.ClearSelection();
		GameObject gameObject = this.content;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.LMEOHKPCHJJ));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-Text"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 4;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-Text"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + ":";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					if (this.AKDDCMDKLED.mapEvent.data[1].Split(new char[]
					{
						','
					})[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						gameObject2.GetComponent<CustomEventEditorHandler>().Init(this.AKDDCMDKLED.mapEvent.data[1].Split(new char[]
						{
							','
						})[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().Init(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("LevelEditor/CustomEventEditor-Text"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>();
			component.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.GBKBDKHPLKG)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component.SelectItem(0, true);
			component.RebuildPanel();
			component.RedrawPanel();
			component.SelectItem(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.HMMBBDJNGGL))), true);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD44 RID: 52548 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void GHMGIHFGGFB()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD45 RID: 52549 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void MLIDLHFDMLG()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD46 RID: 52550 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void DCGENBKAPAL()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD47 RID: 52551 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void NNFMIAFHMJM()
	{
	}

	// Token: 0x0600CD48 RID: 52552 RVA: 0x0049EEF8 File Offset: 0x0049D0F8
	public void GJMOFHNNJPE()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_NeighbourMaxTex").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.EKHOOPGPPGE)).ToList<EditorEventFunctionInfo>();
			this.PFCCMHGLLEL(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.PHDFIAGENEE)).id, null);
		}
	}

	// Token: 0x0600CD49 RID: 52553 RVA: 0x0049EFA8 File Offset: 0x0049D1A8
	public void OnEditedCustomEventFunction()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.GBKBDKHPLKG)).ToList<EditorEventFunctionInfo>();
			this.ChangeEventFunction(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.HMMBBDJNGGL)).id, null);
		}
	}

	// Token: 0x0600CD4A RID: 52554 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void FBPHNEJBDJN()
	{
	}

	// Token: 0x0600CD4B RID: 52555 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void ABBBINHFOIP()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD4C RID: 52556 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void KMEONPMCNJG()
	{
	}

	// Token: 0x0600CD4D RID: 52557 RVA: 0x0049F058 File Offset: 0x0049D258
	public void LDEJELJCPEH(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.GGIFLKMELMP();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.KAJBLFBHAIJ));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("menutheme"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1506f, 240f, 305f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 8;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("settings.disablestoryboard"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(1108f, 1710f, 1477f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "[SERVER] Selected map: ";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("maps." + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1118f, 381f, 1561f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[0];
					char[] array = new char[0];
					array[1] = '!';
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[0];
						char[] array2 = new char[0];
						array2[0] = '"';
						component.OCCJCGEDNEH(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().AKMLEJJBBNG(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("USE_CORNER_DETECTION"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(787f, 166f, 105f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_CenterY").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.OFHCGKJFGDI)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component2.EOPLNNDKJLM(1, false);
			component2.FKPPDOHCLGA();
			component2.PPKOKKBMHJC();
			component2.HOHNMGKJIMF(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.PHFMMNELDEA))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("/").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD4E RID: 52558 RVA: 0x0049F548 File Offset: 0x0049D748
	public void CFLMBNBAJID()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Noise").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.BFEABMIFIEE)).ToList<EditorEventFunctionInfo>();
			this.PAGEIBCLFED(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.DGDCNDCGPCP)).id, null);
		}
	}

	// Token: 0x0600CD4F RID: 52559 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void HIFEICFJLPB()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD50 RID: 52560 RVA: 0x0049F5F8 File Offset: 0x0049D7F8
	public virtual void PMMKJECMJFB()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.PKBNMIFEGBP() + "float,0";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.FMGBIHDGKBI();
		Singleton<UI>.Instance.OCDOOHGMJIA();
	}

	// Token: 0x0600CD51 RID: 52561 RVA: 0x0049F69C File Offset: 0x0049D89C
	public void EBANIPGGFGF()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("Object ID. Case-Sensitive").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.DNIMHEKGJHB)).ToList<EditorEventFunctionInfo>();
			this.FDCDIOJJKOM(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.JPICHJKIMDH)).id, null);
		}
	}

	// Token: 0x0600CD52 RID: 52562 RVA: 0x0049F74C File Offset: 0x0049D94C
	public void BOPGKOENHNB()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("float,0").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.DNIMHEKGJHB)).ToList<EditorEventFunctionInfo>();
			this.ChangeEventFunction(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.NHPDJEKEOKI)).id, null);
		}
	}

	// Token: 0x0600CD53 RID: 52563 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void AIBNKIDADPI()
	{
	}

	// Token: 0x0600CD54 RID: 52564 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void LMBODPGIKKN()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD55 RID: 52565 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void AJFLGKFIBKF()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD56 RID: 52566 RVA: 0x0049F7FC File Offset: 0x0049D9FC
	public virtual void DACOFMPOLEO()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.BKNPEBIOFOE() + "_ScreenResolution";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.DLHMKKOKJPE();
	}

	// Token: 0x0600CD57 RID: 52567 RVA: 0x0049C6AC File Offset: 0x0049A8AC
	public void IFMKLDIEALH()
	{
		this.isEditing = false;
	}

	// Token: 0x0600CD58 RID: 52568 RVA: 0x0049CC58 File Offset: 0x0049AE58
	private bool KMJHLAPHOIE(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.DOOGPJDDJDJ;
	}

	// Token: 0x0600CD59 RID: 52569 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void MMMDPANNAIO()
	{
	}

	// Token: 0x0600CD5A RID: 52570 RVA: 0x0049F8A0 File Offset: 0x0049DAA0
	public void HFDKLFLMAHH(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.DDPPHDJFKOF();
		GameObject gameObject = this.content;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.KMJHLAPHOIE));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("win"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(201f, 993f, 31f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 8;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("1.87"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(1305f, 869f, 201f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "_Red_R";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("." + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(434f, 385f, 1523f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[1];
					char[] array = new char[0];
					array[1] = '\v';
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[1];
						char[] array2 = new char[0];
						array2[1] = '\u0019';
						component.HFHBKIEOOPK(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().LHAENMGOBMM(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("bad"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(846f, 671f, 1157f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_ScreenResolution").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.FFEGPHJKMFK)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component2.HOHNMGKJIMF(1, false);
			component2.KBAJMMDNILB();
			component2.GHHKKJJGOAN();
			component2.HOHNMGKJIMF(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.FBGMHPEEIFC))), true);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("menu.tabid").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD5B RID: 52571 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600CD5C RID: 52572 RVA: 0x0049FD90 File Offset: 0x0049DF90
	public void PFCCMHGLLEL(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.HIHHPDGKCPE(false);
		}
	}

	// Token: 0x0600CD5D RID: 52573 RVA: 0x0049FDB1 File Offset: 0x0049DFB1
	public virtual void CKAFMOMHCLH(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[1];
			this.HIHHPDGKCPE(true);
		}
	}

	// Token: 0x0600CD5E RID: 52574 RVA: 0x0049FDE3 File Offset: 0x0049DFE3
	public virtual void MDEAKDPMIHN(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.HFDKLFLMAHH(true);
		}
	}

	// Token: 0x0600CD5F RID: 52575 RVA: 0x0049FE18 File Offset: 0x0049E018
	public void NIKKNNEKHPF(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.ELOBPADDKGE();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.MGKOFFFHDBG));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("\\n"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(804f, 1707f, 446f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 6;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Added checkpoint"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(291f, 930f, 133f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "color";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("You have added the SecondScrollRect to a scroll view that already has both directions selected" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(814f, 1931f, 423f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[0];
					char[] array = new char[0];
					array[0] = (char)-105;
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						gameObject2.GetComponent<CustomEventEditorHandler>().HFHBKIEOOPK(this.AKDDCMDKLED.mapEvent.data[0].Split(new char[]
						{
							'Z'
						})[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().PJILLPKFCPO(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(755f, 1126f, 1975f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.Init && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("Tonemapper curve texture").GetComponent<DropDownList>();
			component.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.KFNBKFELFLH)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, true, null));
			}
			component.PGCCCGLPAGK(1, true);
			component.EHACGFPNNHP();
			component.EBBKKKHMJBM();
			component.EINGDNGIEMO(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.FBGMHPEEIFC))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find(" evLeave: ").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD60 RID: 52576 RVA: 0x004A0308 File Offset: 0x0049E508
	public virtual void EMPBIOJOKGM()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.KNFDHLOFAFI() + "Tab2Content";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.FMGBIHDGKBI();
		Singleton<UI>.Instance.OFEBBEDPNJP();
	}

	// Token: 0x0600CD61 RID: 52577 RVA: 0x0049E4F6 File Offset: 0x0049C6F6
	public void MLLGGKDGPLB(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.HFDKLFLMAHH(true);
		}
	}

	// Token: 0x0600CD62 RID: 52578 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void LDMPLDJAFAL()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD63 RID: 52579 RVA: 0x004A03AC File Offset: 0x0049E5AC
	public virtual void EEMNCIOOHFK()
	{
		if (this.AKDDCMDKLED)
		{
			Debug.Log("<color=#{0}>{1}</color>" + this.AKDDCMDKLED.mapEvent);
			this.AKDDCMDKLED.mapEvent.data = this.PNIJCGEOHIM;
			this.DOOGPJDDJDJ = this.AKDDCMDKLED.mapEvent.data[1];
			this.LDEJELJCPEH(false);
		}
	}

	// Token: 0x0600CD64 RID: 52580 RVA: 0x004A041C File Offset: 0x0049E61C
	public void GPKPMCINMCI()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("Exit to Windows").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.DNIMHEKGJHB)).ToList<EditorEventFunctionInfo>();
			this.PAGEIBCLFED(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.EEBODGOFEGB)).id, null);
		}
	}

	// Token: 0x0600CD65 RID: 52581 RVA: 0x004A04CC File Offset: 0x0049E6CC
	public void CPIEBJHIGFL(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.ClearSelection();
		GameObject gameObject = this.content;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.JGCAPEAJPLO));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_ScreenResolution"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1895f, 746f, 9f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 2;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_Value"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(652f, 134f, 1240f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "Prints list of all previous commands";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("You need to have a child LayoutGroup content set for the list: " + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1700f, 58f, 1478f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[0];
					char[] array = new char[0];
					array[0] = '/';
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[0];
						char[] array2 = new char[1];
						array2[1] = '\u0003';
						component.IKLAFGHCELK(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().NKLCNJEIAFB(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(","), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(317f, 1278f, 1896f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Value3").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.DKGPCPBNDPK)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, false, null));
			}
			component2.LDBNMDOOJNM(1, false);
			component2.KBAJMMDNILB();
			component2.MEMKGENEOGJ();
			component2.KHPFNJCHEBO(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.FBGMHPEEIFC))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("sfxVolume").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD66 RID: 52582 RVA: 0x004A09BC File Offset: 0x0049EBBC
	public virtual void EMPFNGALCGO(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.LDEJELJCPEH(true);
		}
	}

	// Token: 0x0600CD67 RID: 52583 RVA: 0x004A09EE File Offset: 0x0049EBEE
	public void GHMAFDGDLJP(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.RebuildEditor(false);
		}
	}

	// Token: 0x0600CD68 RID: 52584 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void KOJKBFDNGDK()
	{
	}

	// Token: 0x0600CD69 RID: 52585 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void GPFJMKCGHGB()
	{
	}

	// Token: 0x0600CD6A RID: 52586 RVA: 0x004A0A10 File Offset: 0x0049EC10
	public virtual void BADIACEGCCK()
	{
		if (this.AKDDCMDKLED)
		{
			Debug.Log("maps." + this.AKDDCMDKLED.mapEvent);
			this.AKDDCMDKLED.mapEvent.data = this.PNIJCGEOHIM;
			this.DOOGPJDDJDJ = this.AKDDCMDKLED.mapEvent.data[1];
			this.HIHHPDGKCPE(false);
		}
	}

	// Token: 0x0600CD6B RID: 52587 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void MNBPNHNAEBK()
	{
	}

	// Token: 0x0600CD6C RID: 52588 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void NFEDLAOPHML()
	{
	}

	// Token: 0x0600CD6D RID: 52589 RVA: 0x004A0A80 File Offset: 0x0049EC80
	public virtual void EGMNPDHKIBF()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.FAFMEBBDEHC() + "deletemap";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.PNGLBLFJOOJ();
	}

	// Token: 0x0600CD6E RID: 52590 RVA: 0x004A09BC File Offset: 0x0049EBBC
	public virtual void NAKFBKOPOPP(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.LDEJELJCPEH(true);
		}
	}

	// Token: 0x0600CD6F RID: 52591 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void EPEGAEGDJAM()
	{
	}

	// Token: 0x0600CD70 RID: 52592 RVA: 0x004A0B22 File Offset: 0x0049ED22
	public virtual void DOCDMFEOKAM(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[1];
			this.NIKKNNEKHPF(true);
		}
	}

	// Token: 0x0600CD71 RID: 52593 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void Update()
	{
	}

	// Token: 0x0600CD72 RID: 52594 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void EGEPLFGKGLI()
	{
	}

	// Token: 0x0600CD73 RID: 52595 RVA: 0x0049C6AC File Offset: 0x0049A8AC
	public void GIKNAINHDJH()
	{
		this.isEditing = false;
	}

	// Token: 0x0600CD74 RID: 52596 RVA: 0x004A0B54 File Offset: 0x0049ED54
	public void LCCDOIJNFNF()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Distortion").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.EFAPFFFGOOA)).ToList<EditorEventFunctionInfo>();
			this.PFCCMHGLLEL(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.PHGILLBNBME)).id, null);
		}
	}

	// Token: 0x0600CD75 RID: 52597 RVA: 0x004A0C04 File Offset: 0x0049EE04
	public void MGBGMAAJHJK(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.HPLGACFDEJJ();
		GameObject gameObject = this.content;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.LMEOHKPCHJJ));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("#,0.00"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1504f, 600f, 43f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize += 2;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Right"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(419f, 131f, 592f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "_Value";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_Value4" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1565f, 372f, 1165f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[0];
					char[] array = new char[0];
					array[0] = (char)-55;
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[0];
						char[] array2 = new char[0];
						array2[1] = (char)-118;
						component.EFEONCCCKNP(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().EBMNMBNJDMK(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("set id"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(924f, 111f, 1514f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("menu.selectedmode").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.JKEDCEOCPJO)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, true, null));
			}
			component2.MMFBPCJPION(1, false);
			component2.RebuildPanel();
			component2.EBBKKKHMJBM();
			component2.KHPFNJCHEBO(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.FBGMHPEEIFC))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("music").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD76 RID: 52598 RVA: 0x004A10F4 File Offset: 0x0049F2F4
	public void JDIHOFAKNGG(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.PEEAFFNCLJO(false);
		}
	}

	// Token: 0x0600CD77 RID: 52599 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void MABHOELCKCO()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD78 RID: 52600 RVA: 0x004A1118 File Offset: 0x0049F318
	public virtual void FLMKKHFEJDN()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.GGBNDGIKAPL() + "Item ";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.FMGBIHDGKBI();
		Singleton<UI>.Instance.CCHMCLLHGJF();
	}

	// Token: 0x0600CD79 RID: 52601 RVA: 0x004A11BA File Offset: 0x0049F3BA
	public virtual void AKADPGKKCMF(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[1];
			this.DGNMPBOCIME(true);
		}
	}

	// Token: 0x0600CD7A RID: 52602 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void PHKNALBOJMG()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD7B RID: 52603 RVA: 0x004A11EC File Offset: 0x0049F3EC
	public virtual void BLLMAPNLLJH()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.FAFMEBBDEHC() + "_Value3";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD7C RID: 52604 RVA: 0x004A1278 File Offset: 0x0049F478
	public virtual void KFHDKNBEHLA()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.IMDEOOBEEEM() + "player.xp";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.MCCBKCDPIMK();
	}

	// Token: 0x0600CD7D RID: 52605 RVA: 0x004A131A File Offset: 0x0049F51A
	public virtual void Load(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.RebuildEditor(true);
		}
	}

	// Token: 0x0600CD7E RID: 52606 RVA: 0x004A134C File Offset: 0x0049F54C
	public void EOOIADEPOKC(bool JNMEAJGELBA = true)
	{
		Singleton<UI>.Instance.DDPPHDJFKOF();
		GameObject gameObject = this.content;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		EditorEventFunctionInfo editorEventFunctionInfo = Helpers.eventsMap.Find(new Predicate<EditorEventFunctionInfo>(this.LMEOHKPCHJJ));
		GameObject gameObject2 = null;
		if (editorEventFunctionInfo != null)
		{
			if (editorEventFunctionInfo.functionDescription != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_Value2"), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(484f, 249f, 741f);
				gameObject2.GetComponent<Text>().text = editorEventFunctionInfo.functionDescription;
				gameObject2.GetComponent<Text>().fontSize++;
			}
			foreach (EditorEventFunctionInfo.EditorEventParametr editorEventParametr in editorEventFunctionInfo.parameters)
			{
				if (!string.IsNullOrEmpty(editorEventParametr.name))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("[PlayerController] "), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1383f, 1007f, 1289f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.name.ToUpper() + "The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.";
				}
				gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("_TimeX" + editorEventParametr.editor.ToString()), Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1564f, 579f, 1790f);
				gameObject2.GetComponent<CustomEventEditorHandler>().currentParametr = editorEventParametr;
				try
				{
					string text = this.AKDDCMDKLED.mapEvent.data[0];
					char[] array = new char[1];
					array[1] = 'R';
					if (text.Split(array)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)] != null)
					{
						CustomEventEditorHandler component = gameObject2.GetComponent<CustomEventEditorHandler>();
						string text2 = this.AKDDCMDKLED.mapEvent.data[1];
						char[] array2 = new char[1];
						array2[1] = (char)-127;
						component.AEIMOFGABJG(text2.Split(array2)[editorEventFunctionInfo.parameters.IndexOf(editorEventParametr)], editorEventParametr.data);
					}
				}
				catch (Exception)
				{
					gameObject2.GetComponent<CustomEventEditorHandler>().IMJLEAJNBAF(string.Empty, editorEventParametr.data);
				}
				if (!string.IsNullOrEmpty(editorEventParametr.description))
				{
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys"), Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1184f, 1054f, 1606f);
					gameObject2.GetComponent<Text>().text = editorEventParametr.description;
				}
			}
		}
		if (JNMEAJGELBA && Singleton<MapEditor>.Instance.currentState == MapEditor.EditorState.MapLoaded && this.AKDDCMDKLED != null)
		{
			CustomEventEditor.ADAMMLBOHEC adammlbohec = new CustomEventEditor.ADAMMLBOHEC();
			adammlbohec.ADPIKBBAKHP = this;
			DropDownList component2 = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find(".lastCheckpoint.perfectHits").GetComponent<DropDownList>();
			component2.Items.Clear();
			adammlbohec.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(adammlbohec.LNDGINDKPFA)).ToList<EditorEventFunctionInfo>();
			foreach (EditorEventFunctionInfo editorEventFunctionInfo2 in list)
			{
				component2.Items.Add(new DropDownListItem(editorEventFunctionInfo2.functionName, editorEventFunctionInfo2.id, null, true, null));
			}
			component2.ABEFJKAGJBG(0, false);
			component2.DLLJFCNIMLI();
			component2.IGOACJDBECD();
			component2.KHPFNJCHEBO(list.IndexOf(list.Find(new Predicate<EditorEventFunctionInfo>(adammlbohec.HCFLGKJFKFE))), false);
			Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("Editor/").GetComponent<InputField>().text = string.Empty + this.AKDDCMDKLED.mapEvent.time;
		}
	}

	// Token: 0x0600CD7F RID: 52607 RVA: 0x004A183C File Offset: 0x0049FA3C
	public virtual void JDNDAEFMGFK()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.EPKBPPPMMGA() + "_Distortion";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.NCMDCMHLIKD();
		Singleton<UI>.Instance.DLHMKKOKJPE();
	}

	// Token: 0x0600CD80 RID: 52608 RVA: 0x0049CC58 File Offset: 0x0049AE58
	private bool KAJBLFBHAIJ(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.DOOGPJDDJDJ;
	}

	// Token: 0x0600CD81 RID: 52609 RVA: 0x004A18E0 File Offset: 0x0049FAE0
	public virtual void GJPACOKMPPA()
	{
		if (this.AKDDCMDKLED)
		{
			Debug.Log("_TimeX" + this.AKDDCMDKLED.mapEvent);
			this.AKDDCMDKLED.mapEvent.data = this.PNIJCGEOHIM;
			this.DOOGPJDDJDJ = this.AKDDCMDKLED.mapEvent.data[1];
			this.LDEJELJCPEH(true);
		}
	}

	// Token: 0x0600CD82 RID: 52610 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void ODMPMJPALID()
	{
	}

	// Token: 0x0600CD83 RID: 52611 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void MAOCOEGAFND()
	{
	}

	// Token: 0x0600CD84 RID: 52612 RVA: 0x004A1950 File Offset: 0x0049FB50
	public virtual void KLCFMBBFHHK()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.PGIGEPPBHIG() + "[Right]";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD85 RID: 52613 RVA: 0x004A19DC File Offset: 0x0049FBDC
	public virtual void ELMJNKAACMC()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.EPKBPPPMMGA() + "HandsCountSlider";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.CCHMCLLHGJF();
	}

	// Token: 0x0600CD86 RID: 52614 RVA: 0x0049E4F6 File Offset: 0x0049C6F6
	public void CBGMCLCNLAA(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.HFDKLFLMAHH(true);
		}
	}

	// Token: 0x0600CD87 RID: 52615 RVA: 0x004A09EE File Offset: 0x0049EBEE
	public void ChangeEventFunction(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.RebuildEditor(false);
		}
	}

	// Token: 0x0600CD88 RID: 52616 RVA: 0x0049D87C File Offset: 0x0049BA7C
	public void OGKDALBAEFK(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.NIKKNNEKHPF(false);
		}
	}

	// Token: 0x0600CD89 RID: 52617 RVA: 0x0049C6AC File Offset: 0x0049A8AC
	public void APEBOMDEPAJ()
	{
		this.isEditing = false;
	}

	// Token: 0x0600CD8A RID: 52618 RVA: 0x0049CC58 File Offset: 0x0049AE58
	private bool JGCAPEAJPLO(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.DOOGPJDDJDJ;
	}

	// Token: 0x0600CD8B RID: 52619 RVA: 0x004A1A7E File Offset: 0x0049FC7E
	public virtual void DIJHOKMMDHG(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[1];
			this.HIHHPDGKCPE(false);
		}
	}

	// Token: 0x0600CD8C RID: 52620 RVA: 0x004A1AB0 File Offset: 0x0049FCB0
	public void OMLFHJMOHMG()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("_Red_B").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[0]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.KFNBKFELFLH)).ToList<EditorEventFunctionInfo>();
			this.JDLBMFDFCEO(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.GDFBBMNOGGD)).id, null);
		}
	}

	// Token: 0x0600CD8E RID: 52622 RVA: 0x004A1B60 File Offset: 0x0049FD60
	public virtual void DPLKCAHAGLN()
	{
		if (this.AKDDCMDKLED)
		{
			Debug.Log("Rtt:{0,4} +/-{1,3}" + this.AKDDCMDKLED.mapEvent);
			this.AKDDCMDKLED.mapEvent.data = this.PNIJCGEOHIM;
			this.DOOGPJDDJDJ = this.AKDDCMDKLED.mapEvent.data[1];
			this.EOOIADEPOKC(true);
		}
	}

	// Token: 0x0600CD8F RID: 52623 RVA: 0x004A1BD0 File Offset: 0x0049FDD0
	public virtual void BKHENLKAMDE()
	{
		if (this.AKDDCMDKLED)
		{
			Debug.Log("score" + this.AKDDCMDKLED.mapEvent);
			this.AKDDCMDKLED.mapEvent.data = this.PNIJCGEOHIM;
			this.DOOGPJDDJDJ = this.AKDDCMDKLED.mapEvent.data[0];
			this.CPIEBJHIGFL(false);
		}
	}

	// Token: 0x0600CD90 RID: 52624 RVA: 0x004A1C40 File Offset: 0x0049FE40
	public virtual void FHLDOEAJHMA()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.HDCJGCHLDJF() + "float,1";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.PNGLBLFJOOJ();
	}

	// Token: 0x0600CD91 RID: 52625 RVA: 0x004A1CE4 File Offset: 0x0049FEE4
	public void DEHHJOLCDAI()
	{
		if (Singleton<MapEditor>.Instance.IsMapLoaded())
		{
			CustomEventEditor.MBFGMGNKAAL mbfgmgnkaal = new CustomEventEditor.MBFGMGNKAAL();
			mbfgmgnkaal.AOCNHGMIDGE = Singleton<MapEditor>.Instance.eventConfigCanvas.transform.Find("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.").GetComponent<DropDownList>();
			mbfgmgnkaal.PPJDFMLJIGN = Helpers.IsStoryboardEvent(this.AKDDCMDKLED.mapEvent.data[1]);
			List<EditorEventFunctionInfo> list = Helpers.GetAvailableEditorEvents(Singleton<MapEditor>.Instance.GetEditedMapDataObj().configVersion).Where(new Func<EditorEventFunctionInfo, bool>(mbfgmgnkaal.PBCAHKDLFPE)).ToList<EditorEventFunctionInfo>();
			this.GHMAFDGDLJP(list.Find(new Predicate<EditorEventFunctionInfo>(mbfgmgnkaal.MMJGKBNKFGM)).id, null);
		}
	}

	// Token: 0x0600CD92 RID: 52626 RVA: 0x004A09BC File Offset: 0x0049EBBC
	public virtual void MIHDJJMGNIB(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.LDEJELJCPEH(true);
		}
	}

	// Token: 0x0600CD93 RID: 52627 RVA: 0x004A1D94 File Offset: 0x0049FF94
	public virtual void IBMLNJKDCML()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.FAFMEBBDEHC() + "[NetworkManager] Joined main lobby";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD94 RID: 52628 RVA: 0x004A1E20 File Offset: 0x004A0020
	public virtual void CBDGIEKHPNL()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.PBICFJPONKP() + "/../";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x0600CD95 RID: 52629 RVA: 0x004A1EA9 File Offset: 0x004A00A9
	public void PAGEIBCLFED(string JJNLCJMGJEG, EditorEvent AKDDCMDKLED = null)
	{
		if (this.DOOGPJDDJDJ != JJNLCJMGJEG)
		{
			this.DOOGPJDDJDJ = JJNLCJMGJEG;
			this.EOOIADEPOKC(true);
		}
	}

	// Token: 0x0600CD96 RID: 52630 RVA: 0x004A1ECC File Offset: 0x004A00CC
	public virtual void NGFEFNKJIEE()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.CKEIKLNDBAI() + "BitsData";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.NCMDCMHLIKD();
		Singleton<UI>.Instance.MCCBKCDPIMK();
	}

	// Token: 0x0600CD97 RID: 52631 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void GGGHFCKAELN()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD98 RID: 52632 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void OEENOOGEEHD()
	{
	}

	// Token: 0x0600CD99 RID: 52633 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void KIEJKBNBHMD()
	{
	}

	// Token: 0x0600CD9A RID: 52634 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void Start()
	{
	}

	// Token: 0x0600CD9B RID: 52635 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void BOPKKCAFODF()
	{
	}

	// Token: 0x0600CD9C RID: 52636 RVA: 0x0049BFDD File Offset: 0x0049A1DD
	public void FOLFLIJNOIM()
	{
		this.isEditing = true;
	}

	// Token: 0x0600CD9D RID: 52637 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void LGHCJCFHEMF()
	{
	}

	// Token: 0x0600CD9E RID: 52638 RVA: 0x004A1F70 File Offset: 0x004A0170
	public virtual void IGNAGAFCCLF()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.OCOLHAJFLAH() + "_FarCamera";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.EOEDBFHBPEI();
		Singleton<UI>.Instance.ELOBPADDKGE();
	}

	// Token: 0x0600CD9F RID: 52639 RVA: 0x0049C6AC File Offset: 0x0049A8AC
	public void KONLHCOIJOD()
	{
		this.isEditing = false;
	}

	// Token: 0x0600CDA0 RID: 52640 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void CGDMLHLJIDK()
	{
	}

	// Token: 0x0600CDA1 RID: 52641 RVA: 0x004A2012 File Offset: 0x004A0212
	public virtual void GKEOIEEACNN(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[1];
			this.RebuildEditor(false);
		}
	}

	// Token: 0x0600CDA2 RID: 52642 RVA: 0x0002523B File Offset: 0x0002343B
	public virtual void FIJHDKIPENG()
	{
	}

	// Token: 0x0600CDA3 RID: 52643 RVA: 0x004A2044 File Offset: 0x004A0244
	public virtual void CECAMOPCBHN()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		CustomEventEditorHandler[] componentsInChildren = this.content.GetComponentsInChildren<CustomEventEditorHandler>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			CustomEventEditorHandler customEventEditorHandler = componentsInChildren[i];
			text = text + customEventEditorHandler.HBPJJBALHDO() + "AudioSampler";
		}
		if (text.Length > 1)
		{
			text = text.Remove(text.Length - 0);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.EOEDBFHBPEI();
		Singleton<UI>.Instance.DOGABOPPHBH();
	}

	// Token: 0x0600CDA4 RID: 52644 RVA: 0x004A20E8 File Offset: 0x004A02E8
	public virtual void Apply()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.GetEditedData() + ",";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		Singleton<MapEditor>.Instance.OnApplyCustomEventButton(list);
		this.AKDDCMDKLED.UpdateEvent();
		Singleton<UI>.Instance.ClearSelection();
	}

	// Token: 0x0600CDA5 RID: 52645 RVA: 0x0049D84A File Offset: 0x0049BA4A
	public virtual void BLDDDKKELNH(EditorEvent AKDDCMDKLED)
	{
		if (AKDDCMDKLED)
		{
			this.AKDDCMDKLED = AKDDCMDKLED;
			this.DOOGPJDDJDJ = AKDDCMDKLED.mapEvent.data[0];
			this.IILCEDCGAEN(false);
		}
	}

	// Token: 0x0600CDA6 RID: 52646 RVA: 0x004A218C File Offset: 0x004A038C
	public virtual void CopyEvent()
	{
		List<string> list = new List<string>();
		list.Add(this.DOOGPJDDJDJ);
		string text = string.Empty;
		foreach (CustomEventEditorHandler customEventEditorHandler in this.content.GetComponentsInChildren<CustomEventEditorHandler>())
		{
			text = text + customEventEditorHandler.GetEditedData() + ",";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
		}
		list.Add(text);
		this.PNIJCGEOHIM = list;
	}

	// Token: 0x040017D9 RID: 6105
	public GameObject content;

	// Token: 0x040017DA RID: 6106
	private EditorEvent AKDDCMDKLED;

	// Token: 0x040017DB RID: 6107
	private string DOOGPJDDJDJ;

	// Token: 0x040017DC RID: 6108
	private List<string> PNIJCGEOHIM;

	// Token: 0x040017DD RID: 6109
	public bool isEditing;

	// Token: 0x02000398 RID: 920
	[CompilerGenerated]
	private sealed class MBFGMGNKAAL
	{
		// Token: 0x0600CDA7 RID: 52647 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool JKEDCEOCPJO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x004A222A File Offset: 0x004A042A
		internal bool FBGMHPEEIFC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.SelectedItem.KBFCLFHCEDA();
		}

		// Token: 0x0600CDA9 RID: 52649 RVA: 0x004A2247 File Offset: 0x004A0447
		internal bool GMLFBOMLINM(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.GJHIINGAEJG().LHBHELFAOGF();
		}

		// Token: 0x0600CDAA RID: 52650 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool FMIHBNPKEEO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDAB RID: 52651 RVA: 0x004A2264 File Offset: 0x004A0464
		internal bool NLALPCHCOPE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.ELMAEGKCFAC().DJCDFAEOGGJ();
		}

		// Token: 0x0600CDAC RID: 52652 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool DKGPCPBNDPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDAD RID: 52653 RVA: 0x004A2281 File Offset: 0x004A0481
		internal bool NHPDJEKEOKI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.NLPNJOCNGHA().LHBHELFAOGF();
		}

		// Token: 0x0600CDAE RID: 52654 RVA: 0x004A229E File Offset: 0x004A049E
		internal bool AHBIANHNBBC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.MJIHJHEEOHP().LHBHELFAOGF();
		}

		// Token: 0x0600CDAF RID: 52655 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool GBKBDKHPLKG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB0 RID: 52656 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool EKHOOPGPPGE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB1 RID: 52657 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool DNIMHEKGJHB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool JBAJEMGOPDL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB3 RID: 52659 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool FIPCLHEKKCA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x004A22BB File Offset: 0x004A04BB
		internal bool IPAAAAPBFEG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.MJIHJHEEOHP().ID;
		}

		// Token: 0x0600CDB5 RID: 52661 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool EFAPFFFGOOA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB6 RID: 52662 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool BFEABMIFIEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB7 RID: 52663 RVA: 0x004A22D8 File Offset: 0x004A04D8
		internal bool JPICHJKIMDH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.AHPGIGENBAO().LHBHELFAOGF();
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool FDAIFOAGDLA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool OFLDIMDDLHM(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x004A22F5 File Offset: 0x004A04F5
		internal bool EEBODGOFEGB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.HGGOCKHJLPC().OJIDDODDDAD();
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x004A2312 File Offset: 0x004A0512
		internal bool HMMBBDJNGGL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.SelectedItem.ID;
		}

		// Token: 0x0600CDBC RID: 52668 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool BJMAIJDIKCN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDBD RID: 52669 RVA: 0x004A232F File Offset: 0x004A052F
		internal bool CJDNDHBDMMO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.NLPNJOCNGHA().KBFCLFHCEDA();
		}

		// Token: 0x0600CDBE RID: 52670 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool INHOEMCLAAP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDBF RID: 52671 RVA: 0x004A234C File Offset: 0x004A054C
		internal bool PHFMMNELDEA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.MJIHJHEEOHP().KBFCLFHCEDA();
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool KFNBKFELFLH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x004A2369 File Offset: 0x004A0569
		internal bool PHDFIAGENEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.LNKJOJKJBKL().ID;
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool LLNDDFGPOPL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x004A2312 File Offset: 0x004A0512
		internal bool MMJGKBNKFGM(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.SelectedItem.ID;
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool OFHCGKJFGDI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x004A2386 File Offset: 0x004A0586
		internal bool DGDCNDCGPCP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.AHPGIGENBAO().ID;
		}

		// Token: 0x0600CDC7 RID: 52679 RVA: 0x004A23A3 File Offset: 0x004A05A3
		internal bool GDFBBMNOGGD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.LNKJOJKJBKL().KBFCLFHCEDA();
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool PBCAHKDLFPE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDC9 RID: 52681 RVA: 0x004A22D8 File Offset: 0x004A04D8
		internal bool BPJGFELFEDC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.AHPGIGENBAO().LHBHELFAOGF();
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x004A23C0 File Offset: 0x004A05C0
		internal bool PHGILLBNBME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.GJHIINGAEJG().ID;
		}

		// Token: 0x0600CDCB RID: 52683 RVA: 0x004A23DD File Offset: 0x004A05DD
		internal bool BOPKCHEPEEB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.EMILPCNCJMP().KBFCLFHCEDA();
		}

		// Token: 0x0600CDCC RID: 52684 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool FJDBPPKABJE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDCD RID: 52685 RVA: 0x004A2281 File Offset: 0x004A0481
		internal bool ECGDAHDOPBO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.NLPNJOCNGHA().LHBHELFAOGF();
		}

		// Token: 0x0600CDCE RID: 52686 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool AGJKEBOPIOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDCF RID: 52687 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool BDGDIDPDBHG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD0 RID: 52688 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool AEINPAGJFME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD1 RID: 52689 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool LOEAMHGMMPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x004A234C File Offset: 0x004A054C
		internal bool HNMFCOHLALO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.MJIHJHEEOHP().KBFCLFHCEDA();
		}

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x004A2215 File Offset: 0x004A0415
		internal bool PIJAOCFAPKC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD4 RID: 52692 RVA: 0x004A23FA File Offset: 0x004A05FA
		internal bool HKCAPINMNFF(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.AOCNHGMIDGE.LNKJOJKJBKL().OJIDDODDDAD();
		}

		// Token: 0x040017DE RID: 6110
		internal bool PPJDFMLJIGN;

		// Token: 0x040017DF RID: 6111
		internal DropDownList AOCNHGMIDGE;
	}

	// Token: 0x02000399 RID: 921
	[CompilerGenerated]
	private sealed class ADAMMLBOHEC
	{
		// Token: 0x0600CDD5 RID: 52693 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool DBFPGFHEGKA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD6 RID: 52694 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool OLIGLEMPFOP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD7 RID: 52695 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool FIPCLHEKKCA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD8 RID: 52696 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool BFEABMIFIEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDD9 RID: 52697 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool FBGMHPEEIFC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDDA RID: 52698 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool IPAAAAPBFEG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDDB RID: 52699 RVA: 0x004A2454 File Offset: 0x004A0654
		internal bool HMMBBDJNGGL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[0];
		}

		// Token: 0x0600CDDC RID: 52700 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool FJDBPPKABJE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDDD RID: 52701 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool FFEGPHJKMFK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDDE RID: 52702 RVA: 0x004A2454 File Offset: 0x004A0654
		internal bool LGKMMLGKBEF(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[0];
		}

		// Token: 0x0600CDDF RID: 52703 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool LNDGINDKPFA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDE0 RID: 52704 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool JPGFOBNOBKN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDE1 RID: 52705 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool KFNBKFELFLH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDE2 RID: 52706 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool GDFBBMNOGGD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDE3 RID: 52707 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool JPICHJKIMDH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDE4 RID: 52708 RVA: 0x004A2454 File Offset: 0x004A0654
		internal bool HNMFCOHLALO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[0];
		}

		// Token: 0x0600CDE5 RID: 52709 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool GBKBDKHPLKG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDE6 RID: 52710 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool HCFLGKJFKFE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDE7 RID: 52711 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool AGJKEBOPIOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDE8 RID: 52712 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool AEINPAGJFME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDE9 RID: 52713 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool PHGILLBNBME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDEA RID: 52714 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool JDELIMPGFDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDEB RID: 52715 RVA: 0x004A2454 File Offset: 0x004A0654
		internal bool PHFMMNELDEA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[0];
		}

		// Token: 0x0600CDEC RID: 52716 RVA: 0x004A242C File Offset: 0x004A062C
		internal bool LLGBONGFMBH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.AKDDCMDKLED.mapEvent.data[1];
		}

		// Token: 0x0600CDED RID: 52717 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool BMAOCLKPNNC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDEE RID: 52718 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool DKGPCPBNDPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDEF RID: 52719 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool OFHCGKJFGDI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDF1 RID: 52721 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool JKEDCEOCPJO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDF2 RID: 52722 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool LOEAMHGMMPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x0600CDF3 RID: 52723 RVA: 0x004A2417 File Offset: 0x004A0617
		internal bool PIJAOCFAPKC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return Helpers.IsStoryboardEvent(IACGDFHKCAE.id) == this.PPJDFMLJIGN;
		}

		// Token: 0x040017E0 RID: 6112
		internal bool PPJDFMLJIGN;

		// Token: 0x040017E1 RID: 6113
		internal CustomEventEditor ADPIKBBAKHP;
	}
}
