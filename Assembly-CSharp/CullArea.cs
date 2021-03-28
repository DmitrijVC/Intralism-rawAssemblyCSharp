using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200033D RID: 829
public class CullArea : MonoBehaviour
{
	// Token: 0x0600BB6A RID: 47978 RVA: 0x004428F1 File Offset: 0x00440AF1
	public Dictionary<int, GameObject> KHNIGOOIEEC()
	{
		return this.<HOIHLOCGNFJ>k__BackingField;
	}

	// Token: 0x0600BB6B RID: 47979 RVA: 0x004428F9 File Offset: 0x00440AF9
	public int KPMAKLHIIKH()
	{
		return this.<CECLGELDNPC>k__BackingField;
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x004428F9 File Offset: 0x00440AF9
	// (set) Token: 0x0600BB6C RID: 47980 RVA: 0x00442901 File Offset: 0x00440B01
	public int CellCount { get; private set; }

	// Token: 0x0600BB6D RID: 47981 RVA: 0x0044290A File Offset: 0x00440B0A
	private void AFKHGGAFGDN()
	{
		if (this.LDCIKKFKHMP() != null && this.LDCIKKFKHMP().JLKPMMKNPKN() != null)
		{
			this.BJLDPNNDNKP().OHIODLBAKPJ().GJKLHMCOAGE();
		}
		else
		{
			this.RecreateCellHierarchy = false;
		}
	}

	// Token: 0x0600BB6E RID: 47982 RVA: 0x00442943 File Offset: 0x00440B43
	private void EPCGHAAONLN()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.FEHDNBICKPD();
	}

	// Token: 0x0600BB6F RID: 47983 RVA: 0x00442957 File Offset: 0x00440B57
	public CellTree BJLDPNNDNKP()
	{
		return this.<GCJHHIHBOND>k__BackingField;
	}

	// Token: 0x0600BB70 RID: 47984 RVA: 0x00442943 File Offset: 0x00440B43
	private void HHJBBHEBJCJ()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.FEHDNBICKPD();
	}

	// Token: 0x0600BB71 RID: 47985 RVA: 0x00442957 File Offset: 0x00440B57
	public CellTree LDCIKKFKHMP()
	{
		return this.<GCJHHIHBOND>k__BackingField;
	}

	// Token: 0x0600BB72 RID: 47986 RVA: 0x0044295F File Offset: 0x00440B5F
	private void OIHDEBMIBCD(CellTree DPNHODJHGJL)
	{
		this.<GCJHHIHBOND>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BB73 RID: 47987 RVA: 0x00442968 File Offset: 0x00440B68
	private void LBOBAIGNOML()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.DEPPKCAJAAH();
	}

	// Token: 0x0600BB74 RID: 47988 RVA: 0x0044297C File Offset: 0x00440B7C
	private void JNELLHIPIDO()
	{
		if (this.BJLDPNNDNKP() != null && this.LDCIKKFKHMP().JMBLAEKHIBH() != null)
		{
			this.LDCIKKFKHMP().JMBLAEKHIBH().LIGIABGAEGM();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BB75 RID: 47989 RVA: 0x004429B5 File Offset: 0x00440BB5
	public void OnDrawGizmos()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.FEHDNBICKPD();
		}
		this.EOPIOEHBEHO();
	}

	// Token: 0x0600BB76 RID: 47990 RVA: 0x00442901 File Offset: 0x00440B01
	private void FJEFDOOCPAF(int DPNHODJHGJL)
	{
		this.<CECLGELDNPC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600BB77 RID: 47991 RVA: 0x004429DC File Offset: 0x00440BDC
	private void KPGHEBANPOB(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 2f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 2f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : CellTreeNode.ENodeType.Leaf, OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 2f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 2f;
					cellTreeNode.Center = new Vector3(num5, num8, 0f);
					cellTreeNode.Size = new Vector3(num4, num7, 0f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 2f, num8 - num7 / 2f, 0f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 2f, num8 + num7 / 2f, 0f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 2f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 2f;
					cellTreeNode.Center = new Vector3(num5, 0f, num11);
					cellTreeNode.Size = new Vector3(num4, 0f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 2f, 0f, num11 - num10 / 2f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 2f, 0f, num11 + num10 / 2f);
				}
				OJICGBOIKNA.AddChild(cellTreeNode);
				this.KPGHEBANPOB(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BB78 RID: 47992 RVA: 0x00442C4C File Offset: 0x00440E4C
	private void BANCKPKJKAP(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 0].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 1263f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num2; j += 0)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1346f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)4), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1936f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 578f;
					cellTreeNode.Center = new Vector3(num5, num8, 1815f);
					cellTreeNode.Size = new Vector3(num4, num7, 818f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1113f, num8 - num7 / 1919f, 22f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 687f, num8 + num7 / 460f, 127f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 1606f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1700f;
					cellTreeNode.Center = new Vector3(num5, 522f, num11);
					cellTreeNode.Size = new Vector3(num4, 259f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1193f, 1574f, num11 - num10 / 1100f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1521f, 1020f, num11 + num10 / 1454f);
				}
				OJICGBOIKNA.AddChild(cellTreeNode);
				this.OPNHJGJALEH(cellTreeNode, KNKEPAJGEAH + 0);
			}
		}
	}

	// Token: 0x0600BB79 RID: 47993 RVA: 0x00442EBC File Offset: 0x004410BC
	private void FEHDNBICKPD()
	{
		if (!this.DFCFOIDFBAL())
		{
			if (Debug.isDebugBuild)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"There are too many cells created by your subdivision options. Maximum allowed number of cells is ",
					(int)(250 - this.FIRST_GROUP_ID),
					". Current number of cells is ",
					this.CellCount,
					"."
				}));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Root, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 0f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 0f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 2f, this.Center.y - this.Size.y / 2f, 0f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 2f, this.Center.y + this.Size.y / 2f, 0f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 0f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 0f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 2f, 0f, this.Center.y - this.Size.y / 2f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 2f, 0f, this.Center.y + this.Size.y / 2f);
		}
		this.KPGHEBANPOB(cellTreeNode, 1);
		this.CellTree = new CellTree(cellTreeNode);
		this.RecreateCellHierarchy = false;
	}

	// Token: 0x0600BB7A RID: 47994 RVA: 0x00443200 File Offset: 0x00441400
	private void IMABNMGHDFD(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 0].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 708f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 1541f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Root : CellTreeNode.ENodeType.Leaf, OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1986f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 55f;
					cellTreeNode.Center = new Vector3(num5, num8, 265f);
					cellTreeNode.Size = new Vector3(num4, num7, 1019f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 809f, num8 - num7 / 437f, 1060f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 722f, num8 + num7 / 175f, 420f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 522f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 562f;
					cellTreeNode.Center = new Vector3(num5, 1226f, num11);
					cellTreeNode.Size = new Vector3(num4, 1992f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 1989f, 807f, num11 - num10 / 363f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1044f, 1385f, num11 + num10 / 1435f);
				}
				OJICGBOIKNA.NOOFDCCDCGF(cellTreeNode);
				this.OPNHJGJALEH(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BB7B RID: 47995 RVA: 0x00442943 File Offset: 0x00440B43
	private void Awake()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.FEHDNBICKPD();
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x004428F1 File Offset: 0x00440AF1
	// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x00443470 File Offset: 0x00441670
	public Dictionary<int, GameObject> Map { get; private set; }

	// Token: 0x0600BB7E RID: 47998 RVA: 0x0044347C File Offset: 0x0044167C
	private bool DFCFOIDFBAL()
	{
		int num = 1;
		int num2 = 1;
		foreach (Vector2 vector in this.Subdivisions)
		{
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.CellCount = num * num2;
		return this.CellCount <= (int)(250 - this.FIRST_GROUP_ID);
	}

	// Token: 0x0600BB7F RID: 47999 RVA: 0x004434F0 File Offset: 0x004416F0
	private void OPNHJGJALEH(CellTreeNode OJICGBOIKNA, int KNKEPAJGEAH)
	{
		if (KNKEPAJGEAH > this.NumberOfSubdivisions)
		{
			return;
		}
		int num = (int)this.Subdivisions[KNKEPAJGEAH - 1].x;
		int num2 = (int)this.Subdivisions[KNKEPAJGEAH - 1].y;
		float num3 = OJICGBOIKNA.Center.x - OJICGBOIKNA.Size.x / 645f;
		float num4 = OJICGBOIKNA.Size.x / (float)num;
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num2; j++)
			{
				float num5 = num3 + (float)i * num4 + num4 / 784f;
				byte kdgfpooofea;
				this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 0;
				CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, (this.NumberOfSubdivisions != KNKEPAJGEAH) ? CellTreeNode.ENodeType.Node : ((CellTreeNode.ENodeType)7), OJICGBOIKNA);
				if (this.YIsUpAxis)
				{
					float num6 = OJICGBOIKNA.Center.y - OJICGBOIKNA.Size.y / 1774f;
					float num7 = OJICGBOIKNA.Size.y / (float)num2;
					float num8 = num6 + (float)j * num7 + num7 / 1277f;
					cellTreeNode.Center = new Vector3(num5, num8, 229f);
					cellTreeNode.Size = new Vector3(num4, num7, 1544f);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 746f, num8 - num7 / 895f, 39f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 609f, num8 + num7 / 43f, 1936f);
				}
				else
				{
					float num9 = OJICGBOIKNA.Center.z - OJICGBOIKNA.Size.z / 6f;
					float num10 = OJICGBOIKNA.Size.z / (float)num2;
					float num11 = num9 + (float)j * num10 + num10 / 1507f;
					cellTreeNode.Center = new Vector3(num5, 1997f, num11);
					cellTreeNode.Size = new Vector3(num4, 1057f, num10);
					cellTreeNode.TopLeft = new Vector3(num5 - num4 / 782f, 1578f, num11 - num10 / 1595f);
					cellTreeNode.BottomRight = new Vector3(num5 + num4 / 1791f, 771f, num11 + num10 / 1862f);
				}
				OJICGBOIKNA.BCJDCNIGLEI(cellTreeNode);
				this.BANCKPKJKAP(cellTreeNode, KNKEPAJGEAH + 1);
			}
		}
	}

	// Token: 0x0600BB80 RID: 48000 RVA: 0x00443760 File Offset: 0x00441960
	private bool MMBBMGMEOMO()
	{
		int num = 1;
		int num2 = 1;
		Vector2[] subdivisions = this.Subdivisions;
		for (int i = 1; i < subdivisions.Length; i++)
		{
			Vector2 vector = subdivisions[i];
			num *= (int)vector.x;
			num2 *= (int)vector.y;
		}
		this.CellCount = num * num2;
		return this.CellCount > -105 - (int)this.FIRST_GROUP_ID;
	}

	// Token: 0x0600BB81 RID: 48001 RVA: 0x004437D4 File Offset: 0x004419D4
	private void DEPPKCAJAAH()
	{
		if (!this.MMBBMGMEOMO())
		{
			if (Debug.isDebugBuild)
			{
				object[] array = new object[7];
				array[1] = "color";
				array[1] = (int)(111 - this.FIRST_GROUP_ID);
				array[1] = "_GlowColor";
				array[6] = this.CellCount;
				array[1] = "maps.";
				Debug.LogError(string.Concat(array));
				return;
			}
			Application.Quit();
		}
		byte kdgfpooofea;
		this.KDGFPOOOFEA = (kdgfpooofea = this.KDGFPOOOFEA) + 1;
		CellTreeNode cellTreeNode = new CellTreeNode(kdgfpooofea, CellTreeNode.ENodeType.Node, null);
		if (this.YIsUpAxis)
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.y);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.y);
			cellTreeNode.Center = new Vector3(this.Center.x, this.Center.y, 1941f);
			cellTreeNode.Size = new Vector3(this.Size.x, this.Size.y, 673f);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 746f, this.Center.y - this.Size.y / 429f, 824f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1799f, this.Center.y + this.Size.y / 1932f, 160f);
		}
		else
		{
			this.Center = new Vector2(base.transform.position.x, base.transform.position.z);
			this.Size = new Vector2(base.transform.localScale.x, base.transform.localScale.z);
			cellTreeNode.Center = new Vector3(this.Center.x, 518f, this.Center.y);
			cellTreeNode.Size = new Vector3(this.Size.x, 426f, this.Size.y);
			cellTreeNode.TopLeft = new Vector3(this.Center.x - this.Size.x / 916f, 292f, this.Center.y - this.Size.y / 712f);
			cellTreeNode.BottomRight = new Vector3(this.Center.x + this.Size.x / 1173f, 1903f, this.Center.y + this.Size.y / 1964f);
		}
		this.KPGHEBANPOB(cellTreeNode, 1);
		this.OIHDEBMIBCD(new CellTree(cellTreeNode));
		this.RecreateCellHierarchy = true;
	}

	// Token: 0x0600BB83 RID: 48003 RVA: 0x00443BA0 File Offset: 0x00441DA0
	public void LFJNDDPFLBM()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.FEHDNBICKPD();
		}
		this.AFKHGGAFGDN();
	}

	// Token: 0x0600BB84 RID: 48004 RVA: 0x00443BC8 File Offset: 0x00441DC8
	public List<byte> GetActiveCells(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(0);
		this.CellTree.RootNode.GetActiveCells(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x0600BB85 RID: 48005 RVA: 0x00443BF8 File Offset: 0x00441DF8
	public List<byte> MDICNFNOGEC(Vector3 JOPCODOJBHD)
	{
		List<byte> list = new List<byte>(0);
		this.LDCIKKFKHMP().JIBHJOKKIKB().CKNGPLDAGEB(list, this.YIsUpAxis, JOPCODOJBHD);
		return list;
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x0600BB8B RID: 48011 RVA: 0x00442957 File Offset: 0x00440B57
	// (set) Token: 0x0600BB86 RID: 48006 RVA: 0x0044295F File Offset: 0x00440B5F
	public CellTree CellTree { get; private set; }

	// Token: 0x0600BB87 RID: 48007 RVA: 0x00442968 File Offset: 0x00440B68
	private void CEKLAECJCKG()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		this.DEPPKCAJAAH();
	}

	// Token: 0x0600BB88 RID: 48008 RVA: 0x00443C25 File Offset: 0x00441E25
	public void BDIMPAGMFEK()
	{
		this.KDGFPOOOFEA = this.FIRST_GROUP_ID;
		if (this.RecreateCellHierarchy)
		{
			this.DEPPKCAJAAH();
		}
		this.EOPIOEHBEHO();
	}

	// Token: 0x0600BB89 RID: 48009 RVA: 0x00443C4A File Offset: 0x00441E4A
	private void EOPIOEHBEHO()
	{
		if (this.CellTree != null && this.CellTree.RootNode != null)
		{
			this.CellTree.RootNode.Draw();
		}
		else
		{
			this.RecreateCellHierarchy = true;
		}
	}

	// Token: 0x0600BB8C RID: 48012 RVA: 0x00443470 File Offset: 0x00441670
	private void ILGOHIDFMAB(Dictionary<int, GameObject> DPNHODJHGJL)
	{
		this.<HOIHLOCGNFJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x04001605 RID: 5637
	private const int FEKPDAFDEJL = 250;

	// Token: 0x04001606 RID: 5638
	public const int MAX_NUMBER_OF_SUBDIVISIONS = 3;

	// Token: 0x04001607 RID: 5639
	public readonly byte FIRST_GROUP_ID = 1;

	// Token: 0x04001608 RID: 5640
	public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER = new int[]
	{
		0,
		1,
		1,
		1
	};

	// Token: 0x04001609 RID: 5641
	public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER = new int[]
	{
		0,
		2,
		1,
		2,
		0,
		2,
		1,
		2
	};

	// Token: 0x0400160A RID: 5642
	public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER = new int[]
	{
		0,
		3,
		2,
		3,
		1,
		3,
		2,
		3,
		1,
		3,
		2,
		3
	};

	// Token: 0x0400160B RID: 5643
	public Vector2 Center;

	// Token: 0x0400160C RID: 5644
	public Vector2 Size = new Vector2(25f, 25f);

	// Token: 0x0400160D RID: 5645
	public Vector2[] Subdivisions = new Vector2[3];

	// Token: 0x0400160E RID: 5646
	public int NumberOfSubdivisions;

	// Token: 0x04001612 RID: 5650
	public bool YIsUpAxis = true;

	// Token: 0x04001613 RID: 5651
	public bool RecreateCellHierarchy;

	// Token: 0x04001614 RID: 5652
	private byte KDGFPOOOFEA;
}
