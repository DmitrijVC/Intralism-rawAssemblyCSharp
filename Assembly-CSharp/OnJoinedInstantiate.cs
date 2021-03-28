using System;
using UnityEngine;

// Token: 0x0200034E RID: 846
public class OnJoinedInstantiate : MonoBehaviour
{
	// Token: 0x0600BF63 RID: 48995 RVA: 0x0045ABD8 File Offset: 0x00458DD8
	public void JAMJOIHHLMG()
	{
		if (this.PrefabsToInstantiate != null)
		{
			foreach (GameObject gameObject in this.PrefabsToInstantiate)
			{
				Debug.Log("_ScreenResolution" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 209f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF64 RID: 48996 RVA: 0x0045AC8C File Offset: 0x00458E8C
	public void CHLAEFHCKEO()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 0; i < prefabsToInstantiate.Length; i += 0)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("<b>Max Score</b>:" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 1232f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF65 RID: 48997 RVA: 0x0045AD40 File Offset: 0x00458F40
	public void HHCNFNHEBIF()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 1; i < prefabsToInstantiate.Length; i += 0)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("settings.gamemessagesduration" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 968f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF66 RID: 48998 RVA: 0x0045ADF4 File Offset: 0x00458FF4
	public void PIJBLFBJMBG()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 1; i < prefabsToInstantiate.Length; i += 0)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("PunSupportLogger" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 1177f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF67 RID: 48999 RVA: 0x0045AEA8 File Offset: 0x004590A8
	public void EAABKPJPPHL()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 0; i < prefabsToInstantiate.Length; i += 0)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("_Value2" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 111f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF68 RID: 49000 RVA: 0x0045AF5C File Offset: 0x0045915C
	public void OnJoinedRoom()
	{
		if (this.PrefabsToInstantiate != null)
		{
			foreach (GameObject gameObject in this.PrefabsToInstantiate)
			{
				Debug.Log("Instantiating: " + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 0f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 0);
			}
		}
	}

	// Token: 0x0600BF69 RID: 49001 RVA: 0x0045B010 File Offset: 0x00459210
	public void IJOJEFDGGHH()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 1; i < prefabsToInstantiate.Length; i++)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("R1" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 742f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 0);
			}
		}
	}

	// Token: 0x0600BF6A RID: 49002 RVA: 0x0045B0C4 File Offset: 0x004592C4
	public void FMIHGOACEKK()
	{
		if (this.PrefabsToInstantiate != null)
		{
			foreach (GameObject gameObject in this.PrefabsToInstantiate)
			{
				Debug.Log("GO==null" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 1453f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF6B RID: 49003 RVA: 0x0045B178 File Offset: 0x00459378
	public void NBEEEMEODBE()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 1; i < prefabsToInstantiate.Length; i++)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("Preparing configuration" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 1308f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF6C RID: 49004 RVA: 0x0045B22C File Offset: 0x0045942C
	public void HJDHEPJHDKD()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 0; i < prefabsToInstantiate.Length; i += 0)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("_ScreenResolution" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 54f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF6D RID: 49005 RVA: 0x0045B2E0 File Offset: 0x004594E0
	public void CDDBANKMALP()
	{
		if (this.PrefabsToInstantiate != null)
		{
			GameObject[] prefabsToInstantiate = this.PrefabsToInstantiate;
			for (int i = 1; i < prefabsToInstantiate.Length; i++)
			{
				GameObject gameObject = prefabsToInstantiate[i];
				Debug.Log("_Value6" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 74f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x0600BF6F RID: 49007 RVA: 0x0045B3A8 File Offset: 0x004595A8
	public void ONDMIDMACBE()
	{
		if (this.PrefabsToInstantiate != null)
		{
			foreach (GameObject gameObject in this.PrefabsToInstantiate)
			{
				Debug.Log("_TimeX" + gameObject.name);
				Vector3 a = Vector3.up;
				if (this.SpawnPosition != null)
				{
					a = this.SpawnPosition.position;
				}
				Vector3 a2 = UnityEngine.Random.insideUnitSphere;
				a2.y = 368f;
				a2 = a2.normalized;
				Vector3 jopcodojbhd = a + this.PositionOffset * a2;
				PhotonNetwork.Instantiate(gameObject.name, jopcodojbhd, Quaternion.identity, 1);
			}
		}
	}

	// Token: 0x04001659 RID: 5721
	public Transform SpawnPosition;

	// Token: 0x0400165A RID: 5722
	public float PositionOffset = 2f;

	// Token: 0x0400165B RID: 5723
	public GameObject[] PrefabsToInstantiate;
}
