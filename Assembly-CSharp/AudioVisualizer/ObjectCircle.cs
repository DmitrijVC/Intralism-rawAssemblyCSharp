using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x02000018 RID: 24
	public class ObjectCircle : MonoBehaviour
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x00025FF0 File Offset: 0x000241F0
		private void PEMPABLNJHL()
		{
			this.BHLJGNDEGGJ();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00025FF8 File Offset: 0x000241F8
		private void MLBGEGOKMCK()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 0f;
			float num = 360f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = this.JEELPBBJKDL * 0.0174532924f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 90f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00026188 File Offset: 0x00024388
		private void BHLJGNDEGGJ()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 258f;
			float num = 439f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = this.JEELPBBJKDL * 1026f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 733f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00026318 File Offset: 0x00024518
		private void FMAFBLKAJDF()
		{
			this.MLBGEGOKMCK();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00026320 File Offset: 0x00024520
		private void FANMJNJDMMD()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 645f;
			float num = 577f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = this.JEELPBBJKDL * 1475f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 1473f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000264B0 File Offset: 0x000246B0
		private void EIFCCFBJKOO()
		{
			this.PGHHCIHJIBN();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00026318 File Offset: 0x00024518
		private void Awake()
		{
			this.MLBGEGOKMCK();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000264B8 File Offset: 0x000246B8
		private void FAAJAMIGJNK()
		{
			this.NDGOKBMAHBI();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000264B8 File Offset: 0x000246B8
		private void CEKLAECJCKG()
		{
			this.NDGOKBMAHBI();
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000264C0 File Offset: 0x000246C0
		private void NDGOKBMAHBI()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 1959f;
			float num = 92f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				float f = this.JEELPBBJKDL * 689f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 1434f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00026650 File Offset: 0x00024850
		private void HOJMFHIPBBM()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 1794f;
			float num = 876f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				float f = this.JEELPBBJKDL * 1566f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 319f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000264B0 File Offset: 0x000246B0
		private void BODPLDJLFCF()
		{
			this.PGHHCIHJIBN();
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000267E0 File Offset: 0x000249E0
		private void HOHEMDDJFPJ()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 1605f;
			float num = 779f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = this.JEELPBBJKDL * 410f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 1239f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00026970 File Offset: 0x00024B70
		private void BFIOIDMHPPL()
		{
			this.HOJMFHIPBBM();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00026318 File Offset: 0x00024518
		private void BMAGFLLGDPJ()
		{
			this.MLBGEGOKMCK();
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00026978 File Offset: 0x00024B78
		private void POHMFMNEPKK()
		{
			this.FANMJNJDMMD();
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00025FF0 File Offset: 0x000241F0
		private void IICACFLHBCP()
		{
			this.BHLJGNDEGGJ();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00026318 File Offset: 0x00024518
		private void IIPMEPPIFCK()
		{
			this.MLBGEGOKMCK();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00026980 File Offset: 0x00024B80
		private void MMPOJCFOGJJ()
		{
			this.EBMAGIJEBKG();
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00026988 File Offset: 0x00024B88
		private void JEEINPBLBDI()
		{
			this.MCAICMFPHNL();
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00026990 File Offset: 0x00024B90
		private void PGHHCIHJIBN()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 350f;
			float num = 275f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = this.JEELPBBJKDL * 237f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 873f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00026B20 File Offset: 0x00024D20
		private void EBMAGIJEBKG()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 1762f;
			float num = 62f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = this.JEELPBBJKDL * 1351f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 1129f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00026CB0 File Offset: 0x00024EB0
		private void GEGFJJBCHPE()
		{
			this.HOHEMDDJFPJ();
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00026CB8 File Offset: 0x00024EB8
		private void MCAICMFPHNL()
		{
			foreach (GameObject gameObject in this.objects)
			{
				gameObject.transform.position = base.transform.position;
				gameObject.transform.rotation = base.transform.rotation;
			}
			this.JEELPBBJKDL = 1429f;
			float num = 925f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = this.JEELPBBJKDL * 525f;
				float d = Mathf.Cos(f) * this.radius;
				float d2 = Mathf.Sin(f) * this.radius;
				Vector3 position = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = position;
				this.objects[i].transform.RotateAround(this.objects[i].transform.position, base.transform.forward, this.JEELPBBJKDL - 1079f);
				this.JEELPBBJKDL += num;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00026978 File Offset: 0x00024B78
		private void LOMHIIKFFEP()
		{
			this.FANMJNJDMMD();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000264B0 File Offset: 0x000246B0
		private void JIJPHEDDIHC()
		{
			this.PGHHCIHJIBN();
		}

		// Token: 0x040000C0 RID: 192
		public List<GameObject> objects;

		// Token: 0x040000C1 RID: 193
		public float radius;

		// Token: 0x040000C2 RID: 194
		private float JEELPBBJKDL;
	}
}
