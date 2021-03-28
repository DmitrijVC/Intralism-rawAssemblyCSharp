using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002D6 RID: 726
	[AddComponentMenu("UI/Extensions/VR Cursor")]
	public class VRCursor : MonoBehaviour
	{
		// Token: 0x0600ABBC RID: 43964 RVA: 0x003F7FBE File Offset: 0x003F61BE
		private void KEDGJIHCILG(Collider AGGOHIAAMHN)
		{
			VRInputModule.MHCGECGFPEN(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x003F7FD4 File Offset: 0x003F61D4
		private void DDBOODLPCAM()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 13f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.EJLKOFBJJBO(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x003F8080 File Offset: 0x003F6280
		private void GPFJMKCGHGB()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1300f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.EHEGKPANAGG(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x003F812A File Offset: 0x003F632A
		private void CLCHONJCBLK(Collider AGGOHIAAMHN)
		{
			VRInputModule.LJFOLJGOHHK(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x003F813E File Offset: 0x003F633E
		private void BGBMEKJMABF(Collider AGGOHIAAMHN)
		{
			VRInputModule.NEPBELIOOKK(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x003F8152 File Offset: 0x003F6352
		private void ELHLCLALKJF(Collider AGGOHIAAMHN)
		{
			VRInputModule.LFCACFBDHLM(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x003F8166 File Offset: 0x003F6366
		private void FLNEPIBDKMN(Collider AGGOHIAAMHN)
		{
			VRInputModule.ADDMMNOLDDA(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x003F817C File Offset: 0x003F637C
		private void PFNFPINPCMH()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 826f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.EBJKOOFHMEH(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABC4 RID: 43972 RVA: 0x003F8228 File Offset: 0x003F6428
		private void NDAJBJFJGCF()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1253f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.ANJLIHFDPPL(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x003F82D2 File Offset: 0x003F64D2
		private void HCGCGFGJCDM(Collider AGGOHIAAMHN)
		{
			VRInputModule.PointerExit(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x003F82E8 File Offset: 0x003F64E8
		private void EHJJFJCKGAJ()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 816f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.EBJKOOFHMEH(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x003F8394 File Offset: 0x003F6594
		private void KMEONPMCNJG()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1005f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.PointerSubmit(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x003F843E File Offset: 0x003F663E
		private void OCPGLJBHHCB(Collider AGGOHIAAMHN)
		{
			VRInputModule.FHMEJJFAOCJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x003F8452 File Offset: 0x003F6652
		private void EHFDOPADABJ(Collider AGGOHIAAMHN)
		{
			VRInputModule.DJOLJDIDMLA(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x003F8468 File Offset: 0x003F6668
		private void ONKDMMJPEMN()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 628f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.EJLKOFBJJBO(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x003F8152 File Offset: 0x003F6352
		private void BNLFAIFCGFM(Collider AGGOHIAAMHN)
		{
			VRInputModule.LFCACFBDHLM(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x003F8152 File Offset: 0x003F6352
		private void HCJLFLPADLF(Collider AGGOHIAAMHN)
		{
			VRInputModule.LFCACFBDHLM(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x003F7FBE File Offset: 0x003F61BE
		private void LPADOCGILPK(Collider AGGOHIAAMHN)
		{
			VRInputModule.MHCGECGFPEN(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x003F8512 File Offset: 0x003F6712
		private void FOGLAFCPBIK(Collider AGGOHIAAMHN)
		{
			VRInputModule.FPAOHAHKCME(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x003F8528 File Offset: 0x003F6728
		private void AEIJFLJEABG()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 932f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.PointerSubmit(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x003F85D4 File Offset: 0x003F67D4
		private void MBLDJEFBLFL()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1675f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.KMAGKNNGBMM(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x003F8680 File Offset: 0x003F6880
		private void AAPKBNDHBLI()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 586f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.OBHDPFAGFFL(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x003F872A File Offset: 0x003F692A
		private void GCEIPMBNLFP(Collider AGGOHIAAMHN)
		{
			VRInputModule.INNNBCKAAMO(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x003F8740 File Offset: 0x003F6940
		private void AEEGKLABFLN()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 693f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.JAABNMCDBHI(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x003F87EA File Offset: 0x003F69EA
		private void LBMMPKMELHC(Collider AGGOHIAAMHN)
		{
			VRInputModule.PNMEHHEBNHJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x003F87FE File Offset: 0x003F69FE
		private void DMNABDEPMIE(Collider AGGOHIAAMHN)
		{
			VRInputModule.OJDCHJNHHCL(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x003F8814 File Offset: 0x003F6A14
		private void LCHBFNIPBHB()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 171f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.FIFGMACEOCI(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x003F87FE File Offset: 0x003F69FE
		private void KCHEPBFHGJJ(Collider AGGOHIAAMHN)
		{
			VRInputModule.OJDCHJNHHCL(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x003F88C0 File Offset: 0x003F6AC0
		private void IKIDIJLIGOH()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1862f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.PBJKKMPHMNJ(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x003F896A File Offset: 0x003F6B6A
		private void CMDDGJPDBKA(Collider AGGOHIAAMHN)
		{
			VRInputModule.FOJJCEFEBLG(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x003F897E File Offset: 0x003F6B7E
		private void DBLBEIHAGFB(Collider AGGOHIAAMHN)
		{
			VRInputModule.MGBJFLLOOIP(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x003F872A File Offset: 0x003F692A
		private void MHKJJECCJNP(Collider AGGOHIAAMHN)
		{
			VRInputModule.INNNBCKAAMO(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x003F8992 File Offset: 0x003F6B92
		private void IDMCGHAOEHG(Collider AGGOHIAAMHN)
		{
			VRInputModule.FPGACGKJIHF(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABDD RID: 43997 RVA: 0x003F89A6 File Offset: 0x003F6BA6
		private void APDGGCEKBFF(Collider AGGOHIAAMHN)
		{
			VRInputModule.CGIDPNKFMOG(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABDE RID: 43998 RVA: 0x003F89BA File Offset: 0x003F6BBA
		private void DKOHLAGCEIC(Collider AGGOHIAAMHN)
		{
			VRInputModule.EOJMJMOJKOJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABDF RID: 43999 RVA: 0x003F89BA File Offset: 0x003F6BBA
		private void JELNPBPICAO(Collider AGGOHIAAMHN)
		{
			VRInputModule.EOJMJMOJKOJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x003F82D2 File Offset: 0x003F64D2
		private void ENNNHAKHKIA(Collider AGGOHIAAMHN)
		{
			VRInputModule.PointerExit(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x003F896A File Offset: 0x003F6B6A
		private void KNGAJJPLPOH(Collider AGGOHIAAMHN)
		{
			VRInputModule.FOJJCEFEBLG(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x003F89D0 File Offset: 0x003F6BD0
		private void GMELGGJOPBB()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1159f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.JEOEPNHCCNB(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x003F8A7C File Offset: 0x003F6C7C
		private void EPJJDKJEDMM()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 579f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.KMAGKNNGBMM(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x003F8B28 File Offset: 0x003F6D28
		private void KCDOMIJBFLL()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 398f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.EHEGKPANAGG(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x003F87EA File Offset: 0x003F69EA
		private void NJECBLAKMKB(Collider AGGOHIAAMHN)
		{
			VRInputModule.PNMEHHEBNHJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x003F8BD4 File Offset: 0x003F6DD4
		private void GHILDCBCDJI()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 182f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.KMAGKNNGBMM(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x003F8C80 File Offset: 0x003F6E80
		private void FABMDEHEDNO()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1285f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.KCOPNONNNBI(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x003F8166 File Offset: 0x003F6366
		private void KACHFLJONLL(Collider AGGOHIAAMHN)
		{
			VRInputModule.ADDMMNOLDDA(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x003F897E File Offset: 0x003F6B7E
		private void NCAFDCKMLAH(Collider AGGOHIAAMHN)
		{
			VRInputModule.MGBJFLLOOIP(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x003F8D2A File Offset: 0x003F6F2A
		private void NEGODKBGGKO(Collider AGGOHIAAMHN)
		{
			VRInputModule.GNAMFFDLOML(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x003F8D3E File Offset: 0x003F6F3E
		private void HGIOPMJAGMO(Collider AGGOHIAAMHN)
		{
			VRInputModule.GHLHFGONJHL(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x003F897E File Offset: 0x003F6B7E
		private void IOKPFGDGDJB(Collider AGGOHIAAMHN)
		{
			VRInputModule.MGBJFLLOOIP(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABEE RID: 44014 RVA: 0x003F843E File Offset: 0x003F663E
		private void GPDNACGGHDF(Collider AGGOHIAAMHN)
		{
			VRInputModule.FHMEJJFAOCJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x003F8D52 File Offset: 0x003F6F52
		private void FNNLMLCMDIM(Collider AGGOHIAAMHN)
		{
			VRInputModule.HONDKJEIMLE(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x003F87EA File Offset: 0x003F69EA
		private void LPIECAFHEGI(Collider AGGOHIAAMHN)
		{
			VRInputModule.PNMEHHEBNHJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x003F8D68 File Offset: 0x003F6F68
		private void OCMKCBBCEFG()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 239f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.JEOEPNHCCNB(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x003F8E12 File Offset: 0x003F7012
		private void GJLLKHALHME(Collider AGGOHIAAMHN)
		{
			VRInputModule.FLNEKDOJKLD(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x003F8E28 File Offset: 0x003F7028
		private void IIFCIDDJHPM()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 336f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.EBJKOOFHMEH(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x003F8D3E File Offset: 0x003F6F3E
		private void NOCKLMHDMFN(Collider AGGOHIAAMHN)
		{
			VRInputModule.GHLHFGONJHL(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x003F8ED2 File Offset: 0x003F70D2
		private void OnTriggerEnter(Collider AGGOHIAAMHN)
		{
			VRInputModule.PointerEnter(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x003F8452 File Offset: 0x003F6652
		private void NEECGDEACMK(Collider AGGOHIAAMHN)
		{
			VRInputModule.DJOLJDIDMLA(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x003F8EE6 File Offset: 0x003F70E6
		private void EHECFMPELFG(Collider AGGOHIAAMHN)
		{
			VRInputModule.FADDDHONPAP(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x003F812A File Offset: 0x003F632A
		private void MFODGIHPNEL(Collider AGGOHIAAMHN)
		{
			VRInputModule.LJFOLJGOHHK(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABF9 RID: 44025 RVA: 0x003F8ED2 File Offset: 0x003F70D2
		private void MDJKOKKOJBB(Collider AGGOHIAAMHN)
		{
			VRInputModule.PointerEnter(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABFA RID: 44026 RVA: 0x003F8EFA File Offset: 0x003F70FA
		private void FOBHJKKDIGN(Collider AGGOHIAAMHN)
		{
			VRInputModule.CJODLPBNPAJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABFB RID: 44027 RVA: 0x003F8EFA File Offset: 0x003F70FA
		private void DLCOICAPHNF(Collider AGGOHIAAMHN)
		{
			VRInputModule.CJODLPBNPAJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x003F89A6 File Offset: 0x003F6BA6
		private void PJNDHJDHFML(Collider AGGOHIAAMHN)
		{
			VRInputModule.CGIDPNKFMOG(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x003F896A File Offset: 0x003F6B6A
		private void JABFDOFOABP(Collider AGGOHIAAMHN)
		{
			VRInputModule.FOJJCEFEBLG(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x003F896A File Offset: 0x003F6B6A
		private void NLKBHCJBNFJ(Collider AGGOHIAAMHN)
		{
			VRInputModule.FOJJCEFEBLG(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600ABFF RID: 44031 RVA: 0x003F8F0E File Offset: 0x003F710E
		private void DADAILNBDFJ(Collider AGGOHIAAMHN)
		{
			VRInputModule.FLCPFEGPLFC(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC00 RID: 44032 RVA: 0x003F8F24 File Offset: 0x003F7124
		private void LJIHHJOAJCN()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 720f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.JEOEPNHCCNB(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC01 RID: 44033 RVA: 0x003F8D2A File Offset: 0x003F6F2A
		private void JOFOFJNDNLN(Collider AGGOHIAAMHN)
		{
			VRInputModule.GNAMFFDLOML(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC02 RID: 44034 RVA: 0x003F8FCE File Offset: 0x003F71CE
		private void HELPPNEDCEB(Collider AGGOHIAAMHN)
		{
			VRInputModule.FOEEIECGNNP(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC03 RID: 44035 RVA: 0x003F8EFA File Offset: 0x003F70FA
		private void JHEJLKFKICG(Collider AGGOHIAAMHN)
		{
			VRInputModule.CJODLPBNPAJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC04 RID: 44036 RVA: 0x003F8FE4 File Offset: 0x003F71E4
		private void MDCFIHDPLIG()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 357f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.JAABNMCDBHI(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC05 RID: 44037 RVA: 0x003F9090 File Offset: 0x003F7290
		private void LLDHEJIEDHO()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 845f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.PBJKKMPHMNJ(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC06 RID: 44038 RVA: 0x003F913C File Offset: 0x003F733C
		private void HIKKPDACJGI()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1777f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.OBHDPFAGFFL(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC07 RID: 44039 RVA: 0x003F91E8 File Offset: 0x003F73E8
		private void FGNFILLNPJK()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1420f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.KMAGKNNGBMM(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC08 RID: 44040 RVA: 0x003F7FBE File Offset: 0x003F61BE
		private void FBJFDMPMMEM(Collider AGGOHIAAMHN)
		{
			VRInputModule.MHCGECGFPEN(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC09 RID: 44041 RVA: 0x003F8512 File Offset: 0x003F6712
		private void AACFPHMDIEH(Collider AGGOHIAAMHN)
		{
			VRInputModule.FPAOHAHKCME(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC0A RID: 44042 RVA: 0x003F9294 File Offset: 0x003F7494
		private void DNENFLNCIJP()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 232f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.JAABNMCDBHI(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC0B RID: 44043 RVA: 0x003F87EA File Offset: 0x003F69EA
		private void FALFIFBCKHP(Collider AGGOHIAAMHN)
		{
			VRInputModule.PNMEHHEBNHJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x003F82D2 File Offset: 0x003F64D2
		private void OnTriggerExit(Collider AGGOHIAAMHN)
		{
			VRInputModule.PointerExit(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x003F8F0E File Offset: 0x003F710E
		private void EJKEGMPECCP(Collider AGGOHIAAMHN)
		{
			VRInputModule.FLCPFEGPLFC(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x003F933E File Offset: 0x003F753E
		private void BKLDLIADJMA(Collider AGGOHIAAMHN)
		{
			VRInputModule.KEINJBDIMPM(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x003F9354 File Offset: 0x003F7554
		private void CFIAKIJAILI()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1324f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.EJLKOFBJJBO(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x003F8452 File Offset: 0x003F6652
		private void JNDBPPDBFEN(Collider AGGOHIAAMHN)
		{
			VRInputModule.DJOLJDIDMLA(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC11 RID: 44049 RVA: 0x003F8E12 File Offset: 0x003F7012
		private void KDAOMEEGHGN(Collider AGGOHIAAMHN)
		{
			VRInputModule.FLNEKDOJKLD(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x003F8992 File Offset: 0x003F6B92
		private void JACJIMBCNFM(Collider AGGOHIAAMHN)
		{
			VRInputModule.FPGACGKJIHF(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x003F9400 File Offset: 0x003F7600
		private void LCDJFJIBADI()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1686f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.JEOEPNHCCNB(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x003F8992 File Offset: 0x003F6B92
		private void MIPKBMMNCEF(Collider AGGOHIAAMHN)
		{
			VRInputModule.FPGACGKJIHF(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC15 RID: 44053 RVA: 0x003F94AC File Offset: 0x003F76AC
		private void NEKCPLGFOFD()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 312f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.BJEFLIKJHDC(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC16 RID: 44054 RVA: 0x003F9558 File Offset: 0x003F7758
		private void POJFHDFJOPE()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 250f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.PointerSubmit(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC17 RID: 44055 RVA: 0x003F8EE6 File Offset: 0x003F70E6
		private void JPOGBKFKKLN(Collider AGGOHIAAMHN)
		{
			VRInputModule.FADDDHONPAP(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC18 RID: 44056 RVA: 0x003F9604 File Offset: 0x003F7804
		private void MAOCOEGAFND()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1735f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.EHEGKPANAGG(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x003F96B0 File Offset: 0x003F78B0
		private void Update()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.PointerSubmit(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x003F843E File Offset: 0x003F663E
		private void IFFKLEADEFE(Collider AGGOHIAAMHN)
		{
			VRInputModule.FHMEJJFAOCJ(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x003F975C File Offset: 0x003F795C
		private void AIJGAJIOJDJ()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1343f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.BJEFLIKJHDC(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x003F9808 File Offset: 0x003F7A08
		private void PKHPNHBEKHA()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1145f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.OBHDPFAGFFL(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC1D RID: 44061 RVA: 0x003F7FBE File Offset: 0x003F61BE
		private void ILKHHBJOPCD(Collider AGGOHIAAMHN)
		{
			VRInputModule.MHCGECGFPEN(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC1E RID: 44062 RVA: 0x003F98B4 File Offset: 0x003F7AB4
		private void MECJHOJPODB()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1559f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.EHEGKPANAGG(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC1F RID: 44063 RVA: 0x003F9960 File Offset: 0x003F7B60
		private void LDDKCCMHMIC()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1815f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.PointerSubmit(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x003F9A0C File Offset: 0x003F7C0C
		private void OBAEDJJDCPN()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 885f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(1) && this.DPGLEEGGKPF)
			{
				VRInputModule.EHEGKPANAGG(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x003F9AB6 File Offset: 0x003F7CB6
		private void OLGMFPJAKEN(Collider AGGOHIAAMHN)
		{
			VRInputModule.HHNPEMDHLPK(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x003F9ACA File Offset: 0x003F7CCA
		private void KJNMLFJLPKM(Collider AGGOHIAAMHN)
		{
			VRInputModule.JHIEJCAJDMK(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x003F9AE0 File Offset: 0x003F7CE0
		private void IBFJAOINHMK()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 44f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.EHEGKPANAGG(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x003F9ACA File Offset: 0x003F7CCA
		private void LMLDFEMGAIF(Collider AGGOHIAAMHN)
		{
			VRInputModule.JHIEJCAJDMK(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x003F9B8A File Offset: 0x003F7D8A
		private void GOBGPLDOLAM(Collider AGGOHIAAMHN)
		{
			VRInputModule.HNHHOPCDLCB(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x003F9BA0 File Offset: 0x003F7DA0
		private void LPMINJJPDCH()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 856f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.KMAGKNNGBMM(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC27 RID: 44071 RVA: 0x003F9B8A File Offset: 0x003F7D8A
		private void NBPLMNJFAOD(Collider AGGOHIAAMHN)
		{
			VRInputModule.HNHHOPCDLCB(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC28 RID: 44072 RVA: 0x003F8452 File Offset: 0x003F6652
		private void ADFDJHGFIAJ(Collider AGGOHIAAMHN)
		{
			VRInputModule.DJOLJDIDMLA(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = null;
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x003F872A File Offset: 0x003F692A
		private void OAGDLBBJIDO(Collider AGGOHIAAMHN)
		{
			VRInputModule.INNNBCKAAMO(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x003F89A6 File Offset: 0x003F6BA6
		private void LILDBEEIIAE(Collider AGGOHIAAMHN)
		{
			VRInputModule.CGIDPNKFMOG(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x0600AC2B RID: 44075 RVA: 0x003F9C4C File Offset: 0x003F7E4C
		private void FOLDLDLFFLM()
		{
			Vector3 position;
			position.x = Input.mousePosition.x * this.xSens;
			position.y = Input.mousePosition.y * this.ySens - 1831f;
			position.z = base.transform.position.z;
			base.transform.position = position;
			VRInputModule.cursorPosition = base.transform.position;
			if (Input.GetMouseButtonDown(0) && this.DPGLEEGGKPF)
			{
				VRInputModule.PBJKKMPHMNJ(this.DPGLEEGGKPF.gameObject);
			}
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x003F8F0E File Offset: 0x003F710E
		private void JOLNEGLLODD(Collider AGGOHIAAMHN)
		{
			VRInputModule.FLCPFEGPLFC(AGGOHIAAMHN.gameObject);
			this.DPGLEEGGKPF = AGGOHIAAMHN;
		}

		// Token: 0x04001304 RID: 4868
		public float xSens;

		// Token: 0x04001305 RID: 4869
		public float ySens;

		// Token: 0x04001306 RID: 4870
		private Collider DPGLEEGGKPF;
	}
}
