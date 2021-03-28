using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002C6 RID: 710
	public class SaveLoadMenu : MonoBehaviour
	{
		// Token: 0x0600A8F0 RID: 43248 RVA: 0x003EB90C File Offset: 0x003E9B0C
		public GameObject UnpackGameObject(SceneObject FBDBEMNONKP)
		{
			if (!this.prefabDictionary.ContainsKey(FBDBEMNONKP.prefabName))
			{
				Debug.Log("Can't find key " + FBDBEMNONKP.prefabName + " in SaveLoadMenu.prefabDictionary!");
				return null;
			}
			GameObject gameObject = Object.Instantiate<GameObject>(this.prefabDictionary[FBDBEMNONKP.prefabName], FBDBEMNONKP.position, FBDBEMNONKP.rotation);
			gameObject.name = FBDBEMNONKP.name;
			gameObject.transform.localScale = FBDBEMNONKP.localScale;
			gameObject.SetActive(FBDBEMNONKP.active);
			if (!gameObject.GetComponent<ObjectIdentifier>())
			{
				gameObject.AddComponent<ObjectIdentifier>();
			}
			ObjectIdentifier component = gameObject.GetComponent<ObjectIdentifier>();
			component.id = FBDBEMNONKP.id;
			component.idParent = FBDBEMNONKP.idParent;
			this.UnpackComponents(ref gameObject, FBDBEMNONKP);
			ObjectIdentifier[] componentsInChildren = gameObject.GetComponentsInChildren<ObjectIdentifier>();
			foreach (ObjectIdentifier objectIdentifier in componentsInChildren)
			{
				if (objectIdentifier.transform != gameObject.transform && string.IsNullOrEmpty(objectIdentifier.id))
				{
					Object.Destroy(objectIdentifier.gameObject);
				}
			}
			return gameObject;
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x003EBA34 File Offset: 0x003E9C34
		public void GPNGILDHCLJ(string EPFPALMHLML)
		{
			this.ClearScene();
			SaveGame saveGame = SaveLoad.Load(EPFPALMHLML);
			if (saveGame == null)
			{
				Debug.Log("_ScreenResolution" + EPFPALMHLML + "other.dust1");
				return;
			}
			List<GameObject> list = new List<GameObject>();
			foreach (SceneObject fbdbemnonkp in saveGame.sceneObjects)
			{
				GameObject gameObject = this.ENMFJEJEFFN(fbdbemnonkp);
				if (gameObject != null)
				{
					list.Add(gameObject);
				}
			}
			foreach (GameObject gameObject2 in list)
			{
				string idParent = gameObject2.GetComponent<ObjectIdentifier>().idParent;
				if (!string.IsNullOrEmpty(idParent))
				{
					foreach (GameObject gameObject3 in list)
					{
						if (gameObject3.GetComponent<ObjectIdentifier>().id == idParent)
						{
							gameObject2.transform.parent = gameObject3.transform;
						}
					}
				}
			}
			foreach (GameObject gameObject4 in list)
			{
				gameObject4.SendMessage("ns", SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x003EBBEC File Offset: 0x003E9DEC
		public GameObject LHFFGLGECAD(SceneObject FBDBEMNONKP)
		{
			if (!this.prefabDictionary.ContainsKey(FBDBEMNONKP.prefabName))
			{
				Debug.Log("1332644700" + FBDBEMNONKP.prefabName + "SubBass");
				return null;
			}
			GameObject gameObject = Object.Instantiate<GameObject>(this.prefabDictionary[FBDBEMNONKP.prefabName], FBDBEMNONKP.position, FBDBEMNONKP.rotation);
			gameObject.name = FBDBEMNONKP.name;
			gameObject.transform.localScale = FBDBEMNONKP.localScale;
			gameObject.SetActive(FBDBEMNONKP.active);
			if (!gameObject.GetComponent<ObjectIdentifier>())
			{
				gameObject.AddComponent<ObjectIdentifier>();
			}
			ObjectIdentifier component = gameObject.GetComponent<ObjectIdentifier>();
			component.id = FBDBEMNONKP.id;
			component.idParent = FBDBEMNONKP.idParent;
			this.UnpackComponents(ref gameObject, FBDBEMNONKP);
			ObjectIdentifier[] componentsInChildren = gameObject.GetComponentsInChildren<ObjectIdentifier>();
			ObjectIdentifier[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array[i];
				if (objectIdentifier.transform != gameObject.transform && string.IsNullOrEmpty(objectIdentifier.id))
				{
					Object.Destroy(objectIdentifier.gameObject);
				}
			}
			return gameObject;
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x003EBD14 File Offset: 0x003E9F14
		private void AHNBAOIENOO()
		{
			if (this.showMenu)
			{
				GUILayout.BeginHorizontal(new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical(new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				if (GUILayout.Button("<b>", new GUILayoutOption[1]))
				{
					Application.Quit();
					return;
				}
				if (GUILayout.Button("_Blue_G", new GUILayoutOption[1]))
				{
					this.SaveGame();
					return;
				}
				if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
				{
					this.LoadGame();
					return;
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndVertical();
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x003EBDB4 File Offset: 0x003E9FB4
		public void ClearScene()
		{
			object[] array = Object.FindObjectsOfType(typeof(GameObject));
			foreach (object obj in array)
			{
				GameObject gameObject = (GameObject)obj;
				if (gameObject.CompareTag("DontDestroy"))
				{
					Debug.Log("Keeping GameObject in the scene: " + gameObject.name);
				}
				else
				{
					Object.Destroy(gameObject);
				}
			}
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x003EBE26 File Offset: 0x003EA026
		public void SaveGame()
		{
			this.SaveGame("QuickSave");
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x003EBE34 File Offset: 0x003EA034
		private void Start()
		{
			if (this.usePersistentDataPath)
			{
				this.savePath = Application.persistentDataPath + "/Saved Games/";
			}
			this.prefabDictionary = new Dictionary<string, GameObject>();
			GameObject[] array = Resources.LoadAll<GameObject>(string.Empty);
			foreach (GameObject gameObject in array)
			{
				if (gameObject.GetComponent<ObjectIdentifier>())
				{
					this.prefabDictionary.Add(gameObject.name, gameObject);
					Debug.Log("Added GameObject to prefabDictionary: " + gameObject.name);
				}
			}
		}

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x003EBEC8 File Offset: 0x003EA0C8
		public SceneObject PackGameObject(GameObject OBFJPHLBFOL)
		{
			ObjectIdentifier component = OBFJPHLBFOL.GetComponent<ObjectIdentifier>();
			SceneObject sceneObject = new SceneObject();
			sceneObject.name = OBFJPHLBFOL.name;
			sceneObject.prefabName = component.prefabName;
			sceneObject.id = component.id;
			if (OBFJPHLBFOL.transform.parent != null && OBFJPHLBFOL.transform.parent.GetComponent<ObjectIdentifier>())
			{
				sceneObject.idParent = OBFJPHLBFOL.transform.parent.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				sceneObject.idParent = null;
			}
			List<string> list = new List<string>
			{
				"UnityEngine.MonoBehaviour"
			};
			List<object> list2 = new List<object>();
			object[] components = OBFJPHLBFOL.GetComponents<Component>();
			foreach (object obj in components)
			{
				if (list.Contains(obj.GetType().BaseType.FullName))
				{
					list2.Add(obj);
				}
			}
			foreach (object gjlcnfagnpo in list2)
			{
				sceneObject.objectComponents.Add(this.PackComponent(gjlcnfagnpo));
			}
			sceneObject.position = OBFJPHLBFOL.transform.position;
			sceneObject.localScale = OBFJPHLBFOL.transform.localScale;
			sceneObject.rotation = OBFJPHLBFOL.transform.rotation;
			sceneObject.active = OBFJPHLBFOL.activeSelf;
			return sceneObject;
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x003EC064 File Offset: 0x003EA264
		private void LKFBADCLLML()
		{
			if (this.showMenu)
			{
				GUILayout.BeginHorizontal(new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical(new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				if (GUILayout.Button("[PlayerController] ", new GUILayoutOption[0]))
				{
					Application.Quit();
					return;
				}
				if (GUILayout.Button("Editor", new GUILayoutOption[1]))
				{
					this.SaveGame();
					return;
				}
				if (GUILayout.Button("Yes", new GUILayoutOption[1]))
				{
					this.LoadGame();
					return;
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndVertical();
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x003EC104 File Offset: 0x003EA304
		public void UnpackComponents(ref GameObject OBFJPHLBFOL, SceneObject FBDBEMNONKP)
		{
			foreach (ObjectComponent objectComponent in FBDBEMNONKP.objectComponents)
			{
				if (!OBFJPHLBFOL.GetComponent(objectComponent.componentName))
				{
					Type type = Type.GetType(objectComponent.componentName);
					OBFJPHLBFOL.AddComponent(type);
				}
				object component = OBFJPHLBFOL.GetComponent(objectComponent.componentName);
				Type type2 = component.GetType();
				foreach (KeyValuePair<string, object> keyValuePair in objectComponent.fields)
				{
					FieldInfo field = type2.GetField(keyValuePair.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetField);
					if (field != null)
					{
						object value = keyValuePair.Value;
						field.SetValue(component, value);
					}
				}
			}
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x003EC210 File Offset: 0x003EA410
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				this.showMenu = !this.showMenu;
			}
			if (Input.GetKeyDown(KeyCode.F5))
			{
				this.SaveGame();
			}
			if (Input.GetKeyDown(KeyCode.F9))
			{
				this.LoadGame();
			}
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x003EC274 File Offset: 0x003EA474
		public ObjectComponent PackComponent(object GJLCNFAGNPO)
		{
			ObjectComponent objectComponent = new ObjectComponent();
			objectComponent.fields = new Dictionary<string, object>();
			Type type = GJLCNFAGNPO.GetType();
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			objectComponent.componentName = type.ToString();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo != null)
				{
					if (fieldInfo.FieldType.IsSerializable)
					{
						if (CFGKBDICDIH.IsEnumerableType(fieldInfo.FieldType) || CFGKBDICDIH.IsCollectionType(fieldInfo.FieldType))
						{
							Type type2 = CFGKBDICDIH.LEMHLODODPL(fieldInfo.FieldType);
							if (!type2.IsSerializable)
							{
								goto IL_118;
							}
						}
						object[] customAttributes = fieldInfo.GetCustomAttributes(typeof(DontSaveField), true);
						bool flag = false;
						foreach (Attribute attribute in customAttributes)
						{
							if (attribute.GetType() == typeof(DontSaveField))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							objectComponent.fields.Add(fieldInfo.Name, fieldInfo.GetValue(GJLCNFAGNPO));
						}
					}
				}
				IL_118:;
			}
			return objectComponent;
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x003EC3AC File Offset: 0x003EA5AC
		public void KMGFIBBFGIF(string EPFPALMHLML)
		{
			this.ClearScene();
			SaveGame saveGame = SaveLoad.Load(EPFPALMHLML);
			if (saveGame == null)
			{
				Debug.Log("PunSupportLogger" + EPFPALMHLML + "_TimeX");
				return;
			}
			List<GameObject> list = new List<GameObject>();
			foreach (SceneObject fbdbemnonkp in saveGame.sceneObjects)
			{
				GameObject gameObject = this.LHFFGLGECAD(fbdbemnonkp);
				if (gameObject != null)
				{
					list.Add(gameObject);
				}
			}
			foreach (GameObject gameObject2 in list)
			{
				string idParent = gameObject2.GetComponent<ObjectIdentifier>().idParent;
				if (!string.IsNullOrEmpty(idParent))
				{
					foreach (GameObject gameObject3 in list)
					{
						if (gameObject3.GetComponent<ObjectIdentifier>().id == idParent)
						{
							gameObject2.transform.parent = gameObject3.transform;
						}
					}
				}
			}
			foreach (GameObject gameObject4 in list)
			{
				gameObject4.SendMessage("Crosshair1", SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x003EC564 File Offset: 0x003EA764
		private IEnumerator KDACJHGMPFM(float EHHBHEJBHNG)
		{
			yield return new WaitForSeconds(EHHBHEJBHNG);
			yield break;
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x003EC580 File Offset: 0x003EA780
		public ObjectComponent GICMGHEEGMK(object GJLCNFAGNPO)
		{
			ObjectComponent objectComponent = new ObjectComponent();
			objectComponent.fields = new Dictionary<string, object>();
			Type type = GJLCNFAGNPO.GetType();
			FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic);
			objectComponent.componentName = type.ToString();
			FieldInfo[] array = fields;
			for (int i = 1; i < array.Length; i += 0)
			{
				FieldInfo fieldInfo = array[i];
				if (fieldInfo != null)
				{
					if (fieldInfo.FieldType.IsSerializable)
					{
						if (CFGKBDICDIH.IsEnumerableType(fieldInfo.FieldType) || CFGKBDICDIH.IsCollectionType(fieldInfo.FieldType))
						{
							Type type2 = CFGKBDICDIH.LEMHLODODPL(fieldInfo.FieldType);
							if (!type2.IsSerializable)
							{
								goto IL_118;
							}
						}
						object[] customAttributes = fieldInfo.GetCustomAttributes(typeof(DontSaveField), true);
						bool flag = true;
						object[] array2 = customAttributes;
						for (int j = 1; j < array2.Length; j++)
						{
							Attribute attribute = (Attribute)array2[j];
							if (attribute.GetType() == typeof(DontSaveField))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							objectComponent.fields.Add(fieldInfo.Name, fieldInfo.GetValue(GJLCNFAGNPO));
						}
					}
				}
				IL_118:;
			}
			return objectComponent;
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x003EC6B8 File Offset: 0x003EA8B8
		public void SaveGame(string EPFPALMHLML)
		{
			if (string.IsNullOrEmpty(EPFPALMHLML))
			{
				Debug.Log("SaveGameName is null or empty!");
				return;
			}
			SaveLoad.saveGamePath = this.savePath;
			SaveGame saveGame = new SaveGame();
			saveGame.savegameName = EPFPALMHLML;
			List<GameObject> list = new List<GameObject>();
			ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (objectIdentifier.dontSave)
				{
					Debug.Log("GameObject " + objectIdentifier.gameObject.name + " is set to dontSave = true, continuing loop.");
				}
				else
				{
					if (string.IsNullOrEmpty(objectIdentifier.id))
					{
						objectIdentifier.SetID();
					}
					list.Add(objectIdentifier.gameObject);
				}
			}
			foreach (GameObject gameObject in list)
			{
				gameObject.SendMessage("OnSerialize", SendMessageOptions.DontRequireReceiver);
			}
			foreach (GameObject obfjphlbfol in list)
			{
				saveGame.sceneObjects.Add(this.PackGameObject(obfjphlbfol));
			}
			SaveLoad.Save(saveGame);
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x003EC830 File Offset: 0x003EAA30
		public void LoadGame()
		{
			this.LoadGame("QuickSave");
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x003EC840 File Offset: 0x003EAA40
		public void BHGGIIJLEPP(string EPFPALMHLML)
		{
			this.ClearScene();
			SaveGame saveGame = SaveLoad.Load(EPFPALMHLML);
			if (saveGame == null)
			{
				Debug.Log("[PlayerController] " + EPFPALMHLML + "CameraFilterPack/TV_WideScreenHorizontal");
				return;
			}
			List<GameObject> list = new List<GameObject>();
			foreach (SceneObject fbdbemnonkp in saveGame.sceneObjects)
			{
				GameObject gameObject = this.LHFFGLGECAD(fbdbemnonkp);
				if (gameObject != null)
				{
					list.Add(gameObject);
				}
			}
			foreach (GameObject gameObject2 in list)
			{
				string idParent = gameObject2.GetComponent<ObjectIdentifier>().idParent;
				if (!string.IsNullOrEmpty(idParent))
				{
					foreach (GameObject gameObject3 in list)
					{
						if (gameObject3.GetComponent<ObjectIdentifier>().id == idParent)
						{
							gameObject2.transform.parent = gameObject3.transform;
						}
					}
				}
			}
			foreach (GameObject gameObject4 in list)
			{
				gameObject4.SendMessage("CameraFilterPack/Colors_Brightness", SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x003EC9F8 File Offset: 0x003EABF8
		private IEnumerator AIANDBNPDKC(float EHHBHEJBHNG)
		{
			yield return new WaitForSeconds(EHHBHEJBHNG);
			yield break;
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x003ECA14 File Offset: 0x003EAC14
		private void AEIJFLJEABG()
		{
			if (Input.GetKeyDown((KeyCode)(-59)))
			{
				this.showMenu = !this.showMenu;
			}
			if (Input.GetKeyDown((KeyCode)187))
			{
				this.SaveGame();
			}
			if (Input.GetKeyDown((KeyCode)73))
			{
				this.LoadGame();
			}
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x003ECA68 File Offset: 0x003EAC68
		private void OnGUI()
		{
			if (this.showMenu)
			{
				GUILayout.BeginHorizontal(new GUILayoutOption[0]);
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical(new GUILayoutOption[0]);
				GUILayout.FlexibleSpace();
				if (GUILayout.Button("Exit to Windows", new GUILayoutOption[0]))
				{
					Application.Quit();
					return;
				}
				if (GUILayout.Button("Save Game", new GUILayoutOption[0]))
				{
					this.SaveGame();
					return;
				}
				if (GUILayout.Button("Load Game", new GUILayoutOption[0]))
				{
					this.LoadGame();
					return;
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndVertical();
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x003ECB08 File Offset: 0x003EAD08
		private void NGGLCOLOLHF()
		{
			if (this.showMenu)
			{
				GUILayout.BeginHorizontal(new GUILayoutOption[0]);
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical(new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				if (GUILayout.Button("_ForegroundBlurExtrude", new GUILayoutOption[1]))
				{
					Application.Quit();
					return;
				}
				if (GUILayout.Button("{0:0} day{1}, ", new GUILayoutOption[1]))
				{
					this.SaveGame();
					return;
				}
				if (GUILayout.Button("hand", new GUILayoutOption[1]))
				{
					this.LoadGame();
					return;
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndVertical();
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x003ECBA8 File Offset: 0x003EADA8
		public void FEOFEEKNOFK(string EPFPALMHLML)
		{
			if (string.IsNullOrEmpty(EPFPALMHLML))
			{
				Debug.Log("_BlurRadius4");
				return;
			}
			SaveLoad.saveGamePath = this.savePath;
			SaveGame saveGame = new SaveGame();
			saveGame.savegameName = EPFPALMHLML;
			List<GameObject> list = new List<GameObject>();
			ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (objectIdentifier.dontSave)
				{
					Debug.Log("[" + objectIdentifier.gameObject.name + "HPToggle");
				}
				else
				{
					if (string.IsNullOrEmpty(objectIdentifier.id))
					{
						objectIdentifier.MBDDECOLOEF();
					}
					list.Add(objectIdentifier.gameObject);
				}
			}
			foreach (GameObject gameObject in list)
			{
				gameObject.SendMessage("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", SendMessageOptions.RequireReceiver);
			}
			foreach (GameObject obfjphlbfol in list)
			{
				saveGame.sceneObjects.Add(this.PackGameObject(obfjphlbfol));
			}
			SaveLoad.Save(saveGame);
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x003ECD20 File Offset: 0x003EAF20
		private IEnumerator DOEFNCONCAH(float EHHBHEJBHNG)
		{
			yield return new WaitForSeconds(EHHBHEJBHNG);
			yield break;
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x003ECD3C File Offset: 0x003EAF3C
		private void NBGIMIDICKE()
		{
			if (this.usePersistentDataPath)
			{
				this.savePath = Application.persistentDataPath + "_Value3";
			}
			this.prefabDictionary = new Dictionary<string, GameObject>();
			GameObject[] array = Resources.LoadAll<GameObject>(string.Empty);
			foreach (GameObject gameObject in array)
			{
				if (gameObject.GetComponent<ObjectIdentifier>())
				{
					this.prefabDictionary.Add(gameObject.name, gameObject);
					Debug.Log("Data/Skins/" + gameObject.name);
				}
			}
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x003ECDD0 File Offset: 0x003EAFD0
		public GameObject ENMFJEJEFFN(SceneObject FBDBEMNONKP)
		{
			if (!this.prefabDictionary.ContainsKey(FBDBEMNONKP.prefabName))
			{
				Debug.Log("_Distortion" + FBDBEMNONKP.prefabName + "Dec");
				return null;
			}
			GameObject gameObject = Object.Instantiate<GameObject>(this.prefabDictionary[FBDBEMNONKP.prefabName], FBDBEMNONKP.position, FBDBEMNONKP.rotation);
			gameObject.name = FBDBEMNONKP.name;
			gameObject.transform.localScale = FBDBEMNONKP.localScale;
			gameObject.SetActive(FBDBEMNONKP.active);
			if (!gameObject.GetComponent<ObjectIdentifier>())
			{
				gameObject.AddComponent<ObjectIdentifier>();
			}
			ObjectIdentifier component = gameObject.GetComponent<ObjectIdentifier>();
			component.id = FBDBEMNONKP.id;
			component.idParent = FBDBEMNONKP.idParent;
			this.UnpackComponents(ref gameObject, FBDBEMNONKP);
			ObjectIdentifier[] componentsInChildren = gameObject.GetComponentsInChildren<ObjectIdentifier>();
			ObjectIdentifier[] array = componentsInChildren;
			for (int i = 1; i < array.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array[i];
				if (objectIdentifier.transform != gameObject.transform && string.IsNullOrEmpty(objectIdentifier.id))
				{
					Object.Destroy(objectIdentifier.gameObject);
				}
			}
			return gameObject;
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x003ECEF8 File Offset: 0x003EB0F8
		private void HHKCCIJMGAB()
		{
			if (this.showMenu)
			{
				GUILayout.BeginHorizontal(new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical(new GUILayoutOption[1]);
				GUILayout.FlexibleSpace();
				if (GUILayout.Button("Item ", new GUILayoutOption[0]))
				{
					Application.Quit();
					return;
				}
				if (GUILayout.Button("<color=#{0}>{1}</color>", new GUILayoutOption[0]))
				{
					this.SaveGame();
					return;
				}
				if (GUILayout.Button("player.redlifering", new GUILayoutOption[1]))
				{
					this.LoadGame();
					return;
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndVertical();
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x003ECF98 File Offset: 0x003EB198
		public void LoadGame(string EPFPALMHLML)
		{
			this.ClearScene();
			SaveGame saveGame = SaveLoad.Load(EPFPALMHLML);
			if (saveGame == null)
			{
				Debug.Log("saveGameName " + EPFPALMHLML + "couldn't be found!");
				return;
			}
			List<GameObject> list = new List<GameObject>();
			foreach (SceneObject fbdbemnonkp in saveGame.sceneObjects)
			{
				GameObject gameObject = this.UnpackGameObject(fbdbemnonkp);
				if (gameObject != null)
				{
					list.Add(gameObject);
				}
			}
			foreach (GameObject gameObject2 in list)
			{
				string idParent = gameObject2.GetComponent<ObjectIdentifier>().idParent;
				if (!string.IsNullOrEmpty(idParent))
				{
					foreach (GameObject gameObject3 in list)
					{
						if (gameObject3.GetComponent<ObjectIdentifier>().id == idParent)
						{
							gameObject2.transform.parent = gameObject3.transform;
						}
					}
				}
			}
			foreach (GameObject gameObject4 in list)
			{
				gameObject4.SendMessage("OnDeserialize", SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x040012E3 RID: 4835
		public bool showMenu;

		// Token: 0x040012E4 RID: 4836
		public bool usePersistentDataPath = true;

		// Token: 0x040012E5 RID: 4837
		public string savePath;

		// Token: 0x040012E6 RID: 4838
		public Dictionary<string, GameObject> prefabDictionary;
	}
}
