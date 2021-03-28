using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200033F RID: 831
public class CellTreeNode
{
	// Token: 0x0600BBB8 RID: 48056 RVA: 0x00443CA4 File Offset: 0x00441EA4
	public bool NMBELGEIENA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BBB9 RID: 48057 RVA: 0x00443D50 File Offset: 0x00441F50
	public bool HFJFIGKDLIK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 295f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1190f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBBA RID: 48058 RVA: 0x0002523B File Offset: 0x0002343B
	public void NEMEFLABHLE()
	{
	}

	// Token: 0x0600BBBB RID: 48059 RVA: 0x0002523B File Offset: 0x0002343B
	public void EDEDOPLOHCI()
	{
	}

	// Token: 0x0600BBBC RID: 48060 RVA: 0x0002523B File Offset: 0x0002343B
	public void DHDDGIEELKJ()
	{
	}

	// Token: 0x0600BBBD RID: 48061 RVA: 0x00443DC4 File Offset: 0x00441FC4
	public bool NELBHGAPMDK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600BBBE RID: 48062 RVA: 0x00443E6D File Offset: 0x0044206D
	public void CMPGPNNHNIJ(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBBF RID: 48063 RVA: 0x0002523B File Offset: 0x0002343B
	public void NGLDKNJDCOK()
	{
	}

	// Token: 0x0600BBC0 RID: 48064 RVA: 0x00443E94 File Offset: 0x00442094
	public bool LMDHOOOLOMN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1967f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1057f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBC1 RID: 48065 RVA: 0x00443F08 File Offset: 0x00442108
	public bool PFGGLIDPDOE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BBC2 RID: 48066 RVA: 0x00443FB4 File Offset: 0x004421B4
	public bool MDGFCKNGJPA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BBC3 RID: 48067 RVA: 0x00444060 File Offset: 0x00442260
	public void JANKHBIIGIA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)7)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FIOEMIMKGLF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.AKGEDOANLJA(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.HCIOEHKIGPJ(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBC4 RID: 48068 RVA: 0x0002523B File Offset: 0x0002343B
	public void CHEBDEFBPCJ()
	{
	}

	// Token: 0x0600BBC5 RID: 48069 RVA: 0x00444130 File Offset: 0x00442330
	public void DDPMKCNBBDC(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)6)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FIOEMIMKGLF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.GHBKIJEEOHA(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.PDFBKJPNBNJ(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBC6 RID: 48070 RVA: 0x00444200 File Offset: 0x00442400
	public bool ELLOCFDGHKF(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1515f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 136f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBC7 RID: 48071 RVA: 0x0001E921 File Offset: 0x0001CB21
	public CellTreeNode()
	{
	}

	// Token: 0x0600BBC8 RID: 48072 RVA: 0x0002523B File Offset: 0x0002343B
	public void ECOMEJAKNKF()
	{
	}

	// Token: 0x0600BBC9 RID: 48073 RVA: 0x00444274 File Offset: 0x00442474
	public bool DBDNCGMEPDM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1366f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1116f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBCA RID: 48074 RVA: 0x0002523B File Offset: 0x0002343B
	public void LIGIABGAEGM()
	{
	}

	// Token: 0x0600BBCB RID: 48075 RVA: 0x004442E8 File Offset: 0x004424E8
	public bool GDPBEDNLIJD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1295f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 934f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBCC RID: 48076 RVA: 0x0044435C File Offset: 0x0044255C
	public bool GHBKIJEEOHA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 347f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1472f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBCD RID: 48077 RVA: 0x004443D0 File Offset: 0x004425D0
	public bool GDPIIKAEBHM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 862f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 332f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBCE RID: 48078 RVA: 0x0002523B File Offset: 0x0002343B
	public void GJKLHMCOAGE()
	{
	}

	// Token: 0x0600BBCF RID: 48079 RVA: 0x00444442 File Offset: 0x00442642
	public void NOOFDCCDCGF(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBD0 RID: 48080 RVA: 0x00444468 File Offset: 0x00442668
	public void ANNOEGFBPNC(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)4)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.HGOPIFCAAII(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.AKGEDOANLJA(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.HLDONMPPOJB(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBD1 RID: 48081 RVA: 0x0002523B File Offset: 0x0002343B
	public void Draw()
	{
	}

	// Token: 0x0600BBD2 RID: 48082 RVA: 0x00444538 File Offset: 0x00442738
	public bool FCHJNDHIMAK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BBD3 RID: 48083 RVA: 0x0002523B File Offset: 0x0002343B
	public void LFGHCJAKCOF()
	{
	}

	// Token: 0x0600BBD4 RID: 48084 RVA: 0x00444442 File Offset: 0x00442642
	public void IPECMFMPHLG(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBD5 RID: 48085 RVA: 0x004445E4 File Offset: 0x004427E4
	public void BECEKBEMOHA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Root)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.AHBHLMMJDEC(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.GDPBEDNLIJD(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.GAGLFGAECCN(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBD6 RID: 48086 RVA: 0x0002523B File Offset: 0x0002343B
	public void EMPOBMIAENA()
	{
	}

	// Token: 0x0600BBD7 RID: 48087 RVA: 0x004446B4 File Offset: 0x004428B4
	public void LLBINGMKBHL(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.ALLMEMKPBOE(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.DLCACJNALCB(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.PIPHBDHEMFA(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBD8 RID: 48088 RVA: 0x00444784 File Offset: 0x00442984
	public bool AOBPBKNPDLA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BBD9 RID: 48089 RVA: 0x00444830 File Offset: 0x00442A30
	public bool PJJDGBNGBKN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BBDA RID: 48090 RVA: 0x004448DC File Offset: 0x00442ADC
	public void DFJDCCPEDGA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)8)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.ALLMEMKPBOE(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.NJCLPGMNHLL(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.NMBELGEIENA(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBDB RID: 48091 RVA: 0x00444442 File Offset: 0x00442642
	public void OLDGCEOLDMN(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBDC RID: 48092 RVA: 0x0002523B File Offset: 0x0002343B
	public void BPEEDLPNPCB()
	{
	}

	// Token: 0x0600BBDD RID: 48093 RVA: 0x00444442 File Offset: 0x00442642
	public void MOKFGMHFHFM(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBDE RID: 48094 RVA: 0x004449AC File Offset: 0x00442BAC
	public void FIOEMIMKGLF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FLICAKGALBI(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.ALBHGMHLJMK(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.PDFBKJPNBNJ(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBDF RID: 48095 RVA: 0x00444A7C File Offset: 0x00442C7C
	public bool KELBGKBHOAA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 239f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 73f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBE0 RID: 48096 RVA: 0x00444AF0 File Offset: 0x00442CF0
	public bool OCANCJNGMDJ(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BBE1 RID: 48097 RVA: 0x00444B9C File Offset: 0x00442D9C
	public void BIJNGCBHJOJ(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.IENJCNJFKEN(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.DIJHINFDGGA(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBE2 RID: 48098 RVA: 0x00443E6D File Offset: 0x0044206D
	public void FCGJPIONJMC(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBE3 RID: 48099 RVA: 0x00443E6D File Offset: 0x0044206D
	public void JOGGNNGCKGD(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBE4 RID: 48100 RVA: 0x00444C6C File Offset: 0x00442E6C
	public bool CHBJBCMLFFN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 498f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 402f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBE5 RID: 48101 RVA: 0x00444CE0 File Offset: 0x00442EE0
	public bool NJCLPGMNHLL(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 347f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1126f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBE6 RID: 48102 RVA: 0x00444D54 File Offset: 0x00442F54
	public bool LAFAJGMMMHF(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600BBE7 RID: 48103 RVA: 0x00444E00 File Offset: 0x00443000
	public bool FFBIALNCLMP(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BBE8 RID: 48104 RVA: 0x00444EAC File Offset: 0x004430AC
	public void KEBHODOHCIB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)4)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.KELBGKBHOAA(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.KAEDIAFMHHI(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBE9 RID: 48105 RVA: 0x00444F7C File Offset: 0x0044317C
	public void IKGCEOPLOOP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)6)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.CKNGPLDAGEB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.DLCACJNALCB(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.LNPEFAJLPBF(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBEA RID: 48106 RVA: 0x0044504C File Offset: 0x0044324C
	public bool HIIIPHIKIPI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600BBEB RID: 48107 RVA: 0x0002523B File Offset: 0x0002343B
	public void IKKGIBIJBOJ()
	{
	}

	// Token: 0x0600BBEC RID: 48108 RVA: 0x004450F8 File Offset: 0x004432F8
	public void FLICAKGALBI(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)4)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.KEBHODOHCIB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.JCNLFKEIICC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.LNPEFAJLPBF(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBED RID: 48109 RVA: 0x0002523B File Offset: 0x0002343B
	public void KPOAIENGKDL()
	{
	}

	// Token: 0x0600BBEE RID: 48110 RVA: 0x004451C8 File Offset: 0x004433C8
	public CellTreeNode(byte JMMILEFMACB, CellTreeNode.ENodeType CKEACKJDOPA, CellTreeNode OJICGBOIKNA)
	{
		this.Id = JMMILEFMACB;
		this.NodeType = CKEACKJDOPA;
		this.Parent = OJICGBOIKNA;
	}

	// Token: 0x0600BBEF RID: 48111 RVA: 0x0002523B File Offset: 0x0002343B
	public void FPBMCGDBNNL()
	{
	}

	// Token: 0x0600BBF0 RID: 48112 RVA: 0x004451E8 File Offset: 0x004433E8
	public bool PDFBKJPNBNJ(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BBF1 RID: 48113 RVA: 0x00445294 File Offset: 0x00443494
	public bool POLPIKDALDH(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 113f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 395f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBF2 RID: 48114 RVA: 0x00444442 File Offset: 0x00442642
	public void GODNFNGLIGH(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBF3 RID: 48115 RVA: 0x00444442 File Offset: 0x00442642
	public void KJBNDCHOLEK(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BBF4 RID: 48116 RVA: 0x00445308 File Offset: 0x00443508
	public void APCHLIDFJIA(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Node)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.KDFMFCBIDIF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.IEHKKLFKNOI(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.LAFAJGMMMHF(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBF5 RID: 48117 RVA: 0x004453D8 File Offset: 0x004435D8
	public void GetActiveCells(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.GetActiveCells(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.IsPointNearCell(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.IsPointInsideCell(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBF6 RID: 48118 RVA: 0x004454A8 File Offset: 0x004436A8
	public bool DIJHINFDGGA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BBF7 RID: 48119 RVA: 0x00445554 File Offset: 0x00443754
	public bool PIPHBDHEMFA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BBF8 RID: 48120 RVA: 0x00445600 File Offset: 0x00443800
	public bool FNJENOLOAKD(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BBF9 RID: 48121 RVA: 0x004456AC File Offset: 0x004438AC
	public bool GAKEPBBEMPK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 659f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 265f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBFA RID: 48122 RVA: 0x00445720 File Offset: 0x00443920
	public void NAHNABFFJKF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)5)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.KEBHODOHCIB(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.HOIAMGPNMHM(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.FFBIALNCLMP(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BBFB RID: 48123 RVA: 0x0002523B File Offset: 0x0002343B
	public void DBIDFDBFPMB()
	{
	}

	// Token: 0x0600BBFC RID: 48124 RVA: 0x004457F0 File Offset: 0x004439F0
	public bool IsPointInsideCell(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BBFD RID: 48125 RVA: 0x0044589C File Offset: 0x00443A9C
	public bool EPJJCJICNLI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 528f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 91f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BBFE RID: 48126 RVA: 0x0002523B File Offset: 0x0002343B
	public void OPBKEFPFGDE()
	{
	}

	// Token: 0x0600BBFF RID: 48127 RVA: 0x00445910 File Offset: 0x00443B10
	public bool FLBJIGIGCIE(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 774f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1084f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC00 RID: 48128 RVA: 0x00445984 File Offset: 0x00443B84
	public void GHBGJMMLJLP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)5)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.BECEKBEMOHA(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.GDPIIKAEBHM(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.LAFAJGMMMHF(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC01 RID: 48129 RVA: 0x00445A54 File Offset: 0x00443C54
	public bool GAGLFGAECCN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BC02 RID: 48130 RVA: 0x00444442 File Offset: 0x00442642
	public void BCJDCNIGLEI(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC03 RID: 48131 RVA: 0x00445B00 File Offset: 0x00443D00
	public void BMFHNOGJDOH(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)6)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FIOEMIMKGLF(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.LMDHOOOLOMN(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.MLMKEHJMFLH(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC04 RID: 48132 RVA: 0x00445BD0 File Offset: 0x00443DD0
	public bool JCNLFKEIICC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 925f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1308f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC05 RID: 48133 RVA: 0x00445C44 File Offset: 0x00443E44
	public bool LDFHIFOABBN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BC06 RID: 48134 RVA: 0x0002523B File Offset: 0x0002343B
	public void JCCMGLEJKAO()
	{
	}

	// Token: 0x0600BC07 RID: 48135 RVA: 0x00445CF0 File Offset: 0x00443EF0
	public bool DLCACJNALCB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 399f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 18f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC08 RID: 48136 RVA: 0x00445D64 File Offset: 0x00443F64
	public bool FOLLIEOFKOC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600BC09 RID: 48137 RVA: 0x00445E10 File Offset: 0x00444010
	public void MDPDHOHHGDF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.JANKHBIIGIA(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.EPJJCJICNLI(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.HIIIPHIKIPI(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC0A RID: 48138 RVA: 0x00445EE0 File Offset: 0x004440E0
	public void FGHJJFLABHM(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FLICAKGALBI(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.HOIAMGPNMHM(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.LDEJIAAPNMI(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(0, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC0B RID: 48139 RVA: 0x00445FB0 File Offset: 0x004441B0
	public void HANJAOELBBD(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FLICAKGALBI(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.EEGFPABBMOP(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.HCIOEHKIGPJ(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC0C RID: 48140 RVA: 0x00443E6D File Offset: 0x0044206D
	public void CJCKIJNHEOF(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC0D RID: 48141 RVA: 0x00446080 File Offset: 0x00444280
	public bool HGAFPFHDGOC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BC0E RID: 48142 RVA: 0x0044612C File Offset: 0x0044432C
	public bool HLDONMPPOJB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BC0F RID: 48143 RVA: 0x00444442 File Offset: 0x00442642
	public void ECNBANDEBAJ(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC10 RID: 48144 RVA: 0x004461D8 File Offset: 0x004443D8
	public bool HCIOEHKIGPJ(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BC11 RID: 48145 RVA: 0x00446284 File Offset: 0x00444484
	public bool ALBHGMHLJMK(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1487f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 847f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC12 RID: 48146 RVA: 0x00444442 File Offset: 0x00442642
	public void NCLNCCPEEBA(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC13 RID: 48147 RVA: 0x00443E6D File Offset: 0x0044206D
	public void JOGMBEECLKG(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC14 RID: 48148 RVA: 0x00443E6D File Offset: 0x0044206D
	public void EFMEGDKLJNO(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC15 RID: 48149 RVA: 0x004462F8 File Offset: 0x004444F8
	public bool GHMOLNPCNEM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return false;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BC16 RID: 48150 RVA: 0x00443E6D File Offset: 0x0044206D
	public void NNCHEPFGKGE(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC17 RID: 48151 RVA: 0x00443E6D File Offset: 0x0044206D
	public void HDKELGGAAAP(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC18 RID: 48152 RVA: 0x0002523B File Offset: 0x0002343B
	public void CNLHEHFGFCO()
	{
	}

	// Token: 0x0600BC19 RID: 48153 RVA: 0x004463A4 File Offset: 0x004445A4
	public bool FELLGOKLPKB(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1426f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1014f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC1A RID: 48154 RVA: 0x00446418 File Offset: 0x00444618
	public bool LDEJIAAPNMI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600BC1B RID: 48155 RVA: 0x00444442 File Offset: 0x00442642
	public void OECLDIOKCAN(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC1C RID: 48156 RVA: 0x004464C4 File Offset: 0x004446C4
	public bool IEHKKLFKNOI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 736f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 551f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC1D RID: 48157 RVA: 0x00446538 File Offset: 0x00444738
	public void HGOPIFCAAII(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)8)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.KELBGKBHOAA(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.FNJENOLOAKD(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC1E RID: 48158 RVA: 0x00446608 File Offset: 0x00444808
	public bool AALCHPHNLIN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600BC1F RID: 48159 RVA: 0x004466B4 File Offset: 0x004448B4
	public bool HOIAMGPNMHM(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 494f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 444f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC20 RID: 48160 RVA: 0x00446728 File Offset: 0x00444928
	public bool IsPointNearCell(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 0f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 2f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC21 RID: 48161 RVA: 0x00443E6D File Offset: 0x0044206D
	public void AddChild(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC22 RID: 48162 RVA: 0x0044679C File Offset: 0x0044499C
	public bool DPGDLDAJMID(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1915f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1695f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC23 RID: 48163 RVA: 0x00446810 File Offset: 0x00444A10
	public bool OEBAFFDFHDC(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 809f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 332f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC24 RID: 48164 RVA: 0x00443E6D File Offset: 0x0044206D
	public void EFDEBAIGGJC(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC25 RID: 48165 RVA: 0x00446884 File Offset: 0x00444A84
	public void EPHCAFNANAP(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)6)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.GetActiveCells(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.JCNLFKEIICC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.HCIOEHKIGPJ(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC26 RID: 48166 RVA: 0x00446954 File Offset: 0x00444B54
	public void ALLMEMKPBOE(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Leaf)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.HANJAOELBBD(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.OEBAFFDFHDC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.FNJENOLOAKD(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC27 RID: 48167 RVA: 0x00446A24 File Offset: 0x00444C24
	public bool AKGEDOANLJA(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 1329f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1849f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC28 RID: 48168 RVA: 0x00446A98 File Offset: 0x00444C98
	public bool KAEDIAFMHHI(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BC29 RID: 48169 RVA: 0x00443E6D File Offset: 0x0044206D
	public void BLCMAHBOELD(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC2A RID: 48170 RVA: 0x0002523B File Offset: 0x0002343B
	public void MFFPCCIFFPL()
	{
	}

	// Token: 0x0600BC2B RID: 48171 RVA: 0x00446B44 File Offset: 0x00444D44
	public void KDFMFCBIDIF(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != CellTreeNode.ENodeType.Root)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.FGHJJFLABHM(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.EEGFPABBMOP(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.PFGGLIDPDOE(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(1, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC2C RID: 48172 RVA: 0x00443E6D File Offset: 0x0044206D
	public void CIIPKLDANMM(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC2D RID: 48173 RVA: 0x00444442 File Offset: 0x00442642
	public void BALLCNLCOPI(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC2E RID: 48174 RVA: 0x0002523B File Offset: 0x0002343B
	public void FNOFCBBKHIJ()
	{
	}

	// Token: 0x0600BC2F RID: 48175 RVA: 0x00446C14 File Offset: 0x00444E14
	public bool IENJCNJFKEN(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 97f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 1060f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude <= this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC30 RID: 48176 RVA: 0x00444442 File Offset: 0x00442642
	public void FEJAIKODJON(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(0);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC31 RID: 48177 RVA: 0x00446C88 File Offset: 0x00444E88
	public bool EEGFPABBMOP(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (this.CNPIACHIHKD == 845f)
		{
			this.CNPIACHIHKD = (this.Size.x + this.Size.y + this.Size.z) / 497f;
		}
		return (CGAHPDFGJHH - this.Center).sqrMagnitude > this.CNPIACHIHKD * this.CNPIACHIHKD;
	}

	// Token: 0x0600BC32 RID: 48178 RVA: 0x0002523B File Offset: 0x0002343B
	public void BGBIOINFGLC()
	{
	}

	// Token: 0x0600BC33 RID: 48179 RVA: 0x00446CFC File Offset: 0x00444EFC
	public bool MLMKEHJMFLH(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return true;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BC34 RID: 48180 RVA: 0x00446DA8 File Offset: 0x00444FA8
	public bool LNPEFAJLPBF(bool EFODIOEJNAC, Vector3 CGAHPDFGJHH)
	{
		if (CGAHPDFGJHH.x < this.TopLeft.x || CGAHPDFGJHH.x > this.BottomRight.x)
		{
			return false;
		}
		if (EFODIOEJNAC)
		{
			if (CGAHPDFGJHH.y >= this.TopLeft.y && CGAHPDFGJHH.y <= this.BottomRight.y)
			{
				return true;
			}
		}
		else if (CGAHPDFGJHH.z >= this.TopLeft.z && CGAHPDFGJHH.z <= this.BottomRight.z)
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600BC35 RID: 48181 RVA: 0x00446E54 File Offset: 0x00445054
	public void AHBHLMMJDEC(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)7)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.AHBHLMMJDEC(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.JCNLFKEIICC(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.OCANCJNGMDJ(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x0600BC36 RID: 48182 RVA: 0x00443E6D File Offset: 0x0044206D
	public void DNJFKFABJCI(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC37 RID: 48183 RVA: 0x00443E6D File Offset: 0x0044206D
	public void DIJIAKPIJCL(CellTreeNode FGAAGCEKFLE)
	{
		if (this.Childs == null)
		{
			this.Childs = new List<CellTreeNode>(1);
		}
		this.Childs.Add(FGAAGCEKFLE);
	}

	// Token: 0x0600BC38 RID: 48184 RVA: 0x00446F24 File Offset: 0x00445124
	public void CKNGPLDAGEB(List<byte> NBMPFGDCLEL, bool EFODIOEJNAC, Vector3 JOPCODOJBHD)
	{
		if (this.NodeType != (CellTreeNode.ENodeType)8)
		{
			foreach (CellTreeNode cellTreeNode in this.Childs)
			{
				cellTreeNode.HANJAOELBBD(NBMPFGDCLEL, EFODIOEJNAC, JOPCODOJBHD);
			}
		}
		else if (this.DPGDLDAJMID(EFODIOEJNAC, JOPCODOJBHD))
		{
			if (this.HLDONMPPOJB(EFODIOEJNAC, JOPCODOJBHD))
			{
				NBMPFGDCLEL.Insert(0, this.Id);
				for (CellTreeNode parent = this.Parent; parent != null; parent = parent.Parent)
				{
					NBMPFGDCLEL.Insert(1, parent.Id);
				}
			}
			else
			{
				NBMPFGDCLEL.Add(this.Id);
			}
		}
	}

	// Token: 0x04001616 RID: 5654
	public byte Id;

	// Token: 0x04001617 RID: 5655
	public Vector3 Center;

	// Token: 0x04001618 RID: 5656
	public Vector3 Size;

	// Token: 0x04001619 RID: 5657
	public Vector3 TopLeft;

	// Token: 0x0400161A RID: 5658
	public Vector3 BottomRight;

	// Token: 0x0400161B RID: 5659
	public CellTreeNode.ENodeType NodeType;

	// Token: 0x0400161C RID: 5660
	public CellTreeNode Parent;

	// Token: 0x0400161D RID: 5661
	public List<CellTreeNode> Childs;

	// Token: 0x0400161E RID: 5662
	private float CNPIACHIHKD;

	// Token: 0x02000340 RID: 832
	public enum ENodeType
	{
		// Token: 0x04001620 RID: 5664
		Root,
		// Token: 0x04001621 RID: 5665
		Node,
		// Token: 0x04001622 RID: 5666
		Leaf
	}
}
