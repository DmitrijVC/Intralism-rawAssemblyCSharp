using System;
using UnityEngine;
using UnityEngine.UI.Extensions;

// Token: 0x020002C0 RID: 704
public class TestScript : MonoBehaviour
{
	// Token: 0x0600A861 RID: 43105 RVA: 0x003E548C File Offset: 0x003E368C
	public void DFOMMKEJIKE()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A862 RID: 43106 RVA: 0x003E55B4 File Offset: 0x003E37B4
	public void PDNAOIHPFLF()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A863 RID: 43107 RVA: 0x003E567C File Offset: 0x003E387C
	public void PIONMBEMCID()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A864 RID: 43108 RVA: 0x003E5744 File Offset: 0x003E3944
	public void MFHAMJPCFFK()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A865 RID: 43109 RVA: 0x003E586C File Offset: 0x003E3A6C
	public void GGILOOBKOLL()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A866 RID: 43110 RVA: 0x003E5994 File Offset: 0x003E3B94
	public void OFGONAHPJLA()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A867 RID: 43111 RVA: 0x003E5ABC File Offset: 0x003E3CBC
	public void CHPHHOJBBKD()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A868 RID: 43112 RVA: 0x003E5BE4 File Offset: 0x003E3DE4
	public void KCELFAMOKBB()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A869 RID: 43113 RVA: 0x003E5D0C File Offset: 0x003E3F0C
	public void MKKLOACKFLB()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A86A RID: 43114 RVA: 0x003E5E34 File Offset: 0x003E4034
	public void CLAMJCOPCAJ()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A86B RID: 43115 RVA: 0x003E5EFC File Offset: 0x003E40FC
	public void CACHDBMIIJD()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A86C RID: 43116 RVA: 0x003E5FC4 File Offset: 0x003E41C4
	public void OMPOPGDPEPC()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A86D RID: 43117 RVA: 0x003E608C File Offset: 0x003E428C
	public void EDGHPBFMECO()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A86E RID: 43118 RVA: 0x003E61B4 File Offset: 0x003E43B4
	public void BIHPNPEBBFE()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A86F RID: 43119 RVA: 0x003E627C File Offset: 0x003E447C
	public void GOHFAIPDCIC()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A870 RID: 43120 RVA: 0x003E63A4 File Offset: 0x003E45A4
	public void ONACLLPOBAD()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A871 RID: 43121 RVA: 0x003E646C File Offset: 0x003E466C
	public void NDDFGJOMJFP()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A872 RID: 43122 RVA: 0x003E6594 File Offset: 0x003E4794
	public void OnDeserialize()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A873 RID: 43123 RVA: 0x003E66BC File Offset: 0x003E48BC
	public void KEGCKDGIJIL()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A874 RID: 43124 RVA: 0x003E6784 File Offset: 0x003E4984
	public void DNBEEFPOOEB()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A875 RID: 43125 RVA: 0x003E68AC File Offset: 0x003E4AAC
	public void DECLDDOMAHF()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A876 RID: 43126 RVA: 0x003E69D4 File Offset: 0x003E4BD4
	public void DLMFCMBHDDJ()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A877 RID: 43127 RVA: 0x003E6A9C File Offset: 0x003E4C9C
	public void EDLPBHDPOKF()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A878 RID: 43128 RVA: 0x003E6B64 File Offset: 0x003E4D64
	public void FCLHNNFLABG()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A879 RID: 43129 RVA: 0x003E6C2C File Offset: 0x003E4E2C
	public void OnSerialize()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A87A RID: 43130 RVA: 0x003E6CF4 File Offset: 0x003E4EF4
	public void EGILDNFCGDL()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A87B RID: 43131 RVA: 0x003E6E1C File Offset: 0x003E501C
	public void KOGAJOKEAFN()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A87C RID: 43132 RVA: 0x003E6EE4 File Offset: 0x003E50E4
	public void OGLEGPINICN()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A87D RID: 43133 RVA: 0x003E700C File Offset: 0x003E520C
	public void FCGIBLHPKAJ()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A87E RID: 43134 RVA: 0x003E7134 File Offset: 0x003E5334
	public void CBCDNHIFJFD()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A87F RID: 43135 RVA: 0x003E725C File Offset: 0x003E545C
	public void CHFJCIPAJJM()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A880 RID: 43136 RVA: 0x003E7384 File Offset: 0x003E5584
	public void LIADMHNIEIA()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A881 RID: 43137 RVA: 0x003E744C File Offset: 0x003E564C
	public void DEJHNEAEDPN()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A882 RID: 43138 RVA: 0x003E7574 File Offset: 0x003E5774
	public void LIJHLGJLDJD()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A883 RID: 43139 RVA: 0x003E763C File Offset: 0x003E583C
	public void GCJJPHONNIP()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A884 RID: 43140 RVA: 0x003E7764 File Offset: 0x003E5964
	public void EKMKGNPLFBC()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A885 RID: 43141 RVA: 0x003E788C File Offset: 0x003E5A8C
	public void HJKLOGENNEH()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A886 RID: 43142 RVA: 0x003E79B4 File Offset: 0x003E5BB4
	public void PJLGDAEKEOB()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A887 RID: 43143 RVA: 0x003E7A7C File Offset: 0x003E5C7C
	public void NDBOLDIJMJH()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A889 RID: 43145 RVA: 0x003E7BCC File Offset: 0x003E5DCC
	public void FOJNMKAFJJO()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A88A RID: 43146 RVA: 0x003E7C94 File Offset: 0x003E5E94
	public void HCENOCPBDJF()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A88B RID: 43147 RVA: 0x003E7DBC File Offset: 0x003E5FBC
	public void FFDIGOABHFK()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A88C RID: 43148 RVA: 0x003E7E84 File Offset: 0x003E6084
	public void MGKNBPHPHMG()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A88D RID: 43149 RVA: 0x003E7F4C File Offset: 0x003E614C
	public void OICHAEOOBBK()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A88E RID: 43150 RVA: 0x003E8014 File Offset: 0x003E6214
	public void ALLDKBEMDHF()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A88F RID: 43151 RVA: 0x003E813C File Offset: 0x003E633C
	public void IEJHGCNCJBI()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A890 RID: 43152 RVA: 0x003E8204 File Offset: 0x003E6404
	public void JJODFACOGBL()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A891 RID: 43153 RVA: 0x003E82CC File Offset: 0x003E64CC
	public void AIIDAPOCBKF()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A892 RID: 43154 RVA: 0x003E8394 File Offset: 0x003E6594
	public void OANFGLLMCGN()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A893 RID: 43155 RVA: 0x003E845C File Offset: 0x003E665C
	public void FFHCFAMLHHP()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A894 RID: 43156 RVA: 0x003E8584 File Offset: 0x003E6784
	public void IHNBAJKDBDO()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A895 RID: 43157 RVA: 0x003E864C File Offset: 0x003E684C
	public void PNEFIEEAKBE()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A896 RID: 43158 RVA: 0x003E8774 File Offset: 0x003E6974
	public void DMICDILCOMB()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A897 RID: 43159 RVA: 0x003E889C File Offset: 0x003E6A9C
	public void BGJDEIOOMGO()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A898 RID: 43160 RVA: 0x003E89C4 File Offset: 0x003E6BC4
	public void HIJBOKBNMAF()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A899 RID: 43161 RVA: 0x003E8A8C File Offset: 0x003E6C8C
	public void GIAAOMJJHBP()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A89A RID: 43162 RVA: 0x003E8BB4 File Offset: 0x003E6DB4
	public void JJAIAELHECG()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A89B RID: 43163 RVA: 0x003E8C7C File Offset: 0x003E6E7C
	public void FBOECKEKANJ()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A89C RID: 43164 RVA: 0x003E8DA4 File Offset: 0x003E6FA4
	public void NFGDOEJHODB()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A89D RID: 43165 RVA: 0x003E8E6C File Offset: 0x003E706C
	public void IKIEGNMHBPG()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A89E RID: 43166 RVA: 0x003E8F94 File Offset: 0x003E7194
	public void AJCPGGFCNHO()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A89F RID: 43167 RVA: 0x003E90BC File Offset: 0x003E72BC
	public void AMDFIEJHKDL()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8A0 RID: 43168 RVA: 0x003E91E4 File Offset: 0x003E73E4
	public void FFJAGGLEJKP()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8A1 RID: 43169 RVA: 0x003E930C File Offset: 0x003E750C
	public void GMINHABODLC()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8A2 RID: 43170 RVA: 0x003E9434 File Offset: 0x003E7634
	public void BBMMNMKFDDD()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8A3 RID: 43171 RVA: 0x003E94FC File Offset: 0x003E76FC
	public void GEKNBFACIHO()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8A4 RID: 43172 RVA: 0x003E95C4 File Offset: 0x003E77C4
	public void AICOBOCHNBK()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8A5 RID: 43173 RVA: 0x003E968C File Offset: 0x003E788C
	public void JNBJKONDFDO()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8A6 RID: 43174 RVA: 0x003E97B4 File Offset: 0x003E79B4
	public void GKOKDHJFLPM()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8A7 RID: 43175 RVA: 0x003E98DC File Offset: 0x003E7ADC
	public void COFMFGLKCDH()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8A8 RID: 43176 RVA: 0x003E99A4 File Offset: 0x003E7BA4
	public void MHDGIEPEIPL()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8A9 RID: 43177 RVA: 0x003E9A6C File Offset: 0x003E7C6C
	public void AEHJHPEBCNP()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 0; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8AA RID: 43178 RVA: 0x003E9B94 File Offset: 0x003E7D94
	public void MGANMCDBGFN()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 1; j < array3.Length; j++)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8AB RID: 43179 RVA: 0x003E9CBC File Offset: 0x003E7EBC
	public void CMIAEMCNBDN()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8AC RID: 43180 RVA: 0x003E9D84 File Offset: 0x003E7F84
	public void KEHDHJIEEEB()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					foreach (ObjectIdentifier objectIdentifier2 in array)
					{
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8AD RID: 43181 RVA: 0x003E9EAC File Offset: 0x003E80AC
	public void JLPNNFGAMHM()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i++)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8AE RID: 43182 RVA: 0x003E9F74 File Offset: 0x003E8174
	public void HAHMEDNGMBM()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k += 0)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8AF RID: 43183 RVA: 0x003EA09C File Offset: 0x003E829C
	public void DONFHJMHHEL()
	{
		ObjectIdentifier[] array = UnityEngine.Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(this.someGameObject_id))
		{
			foreach (ObjectIdentifier objectIdentifier in array)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == this.someGameObject_id)
				{
					this.someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (this.testClassArray != null)
		{
			TestClass[] array3 = this.testClassArray;
			for (int j = 0; j < array3.Length; j += 0)
			{
				TestClass testClass = array3[j];
				if (!string.IsNullOrEmpty(testClass.go_id))
				{
					ObjectIdentifier[] array4 = array;
					for (int k = 1; k < array4.Length; k++)
					{
						ObjectIdentifier objectIdentifier2 = array4[k];
						if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
						{
							testClass.go = objectIdentifier2.gameObject;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8B0 RID: 43184 RVA: 0x003EA1C4 File Offset: 0x003E83C4
	public void AMLPMFHKNLL()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			foreach (TestClass testClass in this.testClassArray)
			{
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8B1 RID: 43185 RVA: 0x003EA28C File Offset: 0x003E848C
	public void KIGANJNINJN()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 1; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x0600A8B2 RID: 43186 RVA: 0x003EA354 File Offset: 0x003E8554
	public void FJMGEJAFEAO()
	{
		if (this.someGameObject != null && this.someGameObject.GetComponent<ObjectIdentifier>())
		{
			this.someGameObject_id = this.someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			this.someGameObject_id = null;
		}
		if (this.testClassArray != null)
		{
			TestClass[] array = this.testClassArray;
			for (int i = 0; i < array.Length; i += 0)
			{
				TestClass testClass = array[i];
				if (testClass.go != null && testClass.go.GetComponent<ObjectIdentifier>())
				{
					testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
				}
				else
				{
					testClass.go_id = null;
				}
			}
		}
	}

	// Token: 0x040012CB RID: 4811
	public string testString = "Hello";

	// Token: 0x040012CC RID: 4812
	public GameObject someGameObject;

	// Token: 0x040012CD RID: 4813
	public string someGameObject_id;

	// Token: 0x040012CE RID: 4814
	public TestClass testClass = new TestClass();

	// Token: 0x040012CF RID: 4815
	public TestClass[] testClassArray = new TestClass[2];

	// Token: 0x040012D0 RID: 4816
	[DontSaveField]
	public Transform TransformThatWontBeSaved;
}
