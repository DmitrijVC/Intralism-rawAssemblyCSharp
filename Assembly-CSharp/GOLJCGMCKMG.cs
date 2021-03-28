using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020002D8 RID: 728
internal static class GOLJCGMCKMG
{
	// Token: 0x0600AC81 RID: 44161 RVA: 0x003FAE4C File Offset: 0x003F904C
	internal static void FJPBNMBIOHG()
	{
		Type typeFromHandle = typeof(Vector2);
		byte code = 87;
		if (GOLJCGMCKMG.BOGJGOAMCHK == null)
		{
			GOLJCGMCKMG.BOGJGOAMCHK = new SerializeStreamMethod(GOLJCGMCKMG.LCNMHEMBEFI);
		}
		SerializeStreamMethod bogjgoamchk = GOLJCGMCKMG.BOGJGOAMCHK;
		if (GOLJCGMCKMG.BDPNFNJNEFM == null)
		{
			GOLJCGMCKMG.BDPNFNJNEFM = new DeserializeStreamMethod(GOLJCGMCKMG.HANJLNGFAKP);
		}
		PhotonPeer.RegisterType(typeFromHandle, code, bogjgoamchk, GOLJCGMCKMG.BDPNFNJNEFM);
		Type typeFromHandle2 = typeof(Vector3);
		byte code2 = 86;
		if (GOLJCGMCKMG.MJKNAFJKDMG == null)
		{
			GOLJCGMCKMG.MJKNAFJKDMG = new SerializeStreamMethod(GOLJCGMCKMG.ANBBLBLNDBH);
		}
		SerializeStreamMethod mjknafjkdmg = GOLJCGMCKMG.MJKNAFJKDMG;
		if (GOLJCGMCKMG.JENGHDFDLII == null)
		{
			GOLJCGMCKMG.JENGHDFDLII = new DeserializeStreamMethod(GOLJCGMCKMG.BFLLDNIBMHP);
		}
		PhotonPeer.RegisterType(typeFromHandle2, code2, mjknafjkdmg, GOLJCGMCKMG.JENGHDFDLII);
		Type typeFromHandle3 = typeof(Quaternion);
		byte code3 = 81;
		if (GOLJCGMCKMG.BMJHMBNEACI == null)
		{
			GOLJCGMCKMG.BMJHMBNEACI = new SerializeStreamMethod(GOLJCGMCKMG.PKPCNJJBOJB);
		}
		SerializeStreamMethod bmjhmbneaci = GOLJCGMCKMG.BMJHMBNEACI;
		if (GOLJCGMCKMG.EPENHHMDDMB == null)
		{
			GOLJCGMCKMG.EPENHHMDDMB = new DeserializeStreamMethod(GOLJCGMCKMG.BNPJAGNEBPN);
		}
		PhotonPeer.RegisterType(typeFromHandle3, code3, bmjhmbneaci, GOLJCGMCKMG.EPENHHMDDMB);
		Type typeFromHandle4 = typeof(PhotonPlayer);
		byte code4 = 80;
		if (GOLJCGMCKMG.DNLDPCIINIC == null)
		{
			GOLJCGMCKMG.DNLDPCIINIC = new SerializeStreamMethod(GOLJCGMCKMG.AJKFOONFMDK);
		}
		SerializeStreamMethod dnldpciinic = GOLJCGMCKMG.DNLDPCIINIC;
		if (GOLJCGMCKMG.ILAKDECCIME == null)
		{
			GOLJCGMCKMG.ILAKDECCIME = new DeserializeStreamMethod(GOLJCGMCKMG.AEKFJLLFGFB);
		}
		PhotonPeer.RegisterType(typeFromHandle4, code4, dnldpciinic, GOLJCGMCKMG.ILAKDECCIME);
	}

	// Token: 0x0600AC82 RID: 44162 RVA: 0x003FAF8C File Offset: 0x003F918C
	private static short ANBBLBLNDBH(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Vector3 vector = (Vector3)CCKPKLEKCFF;
		int num = 0;
		object obj = GOLJCGMCKMG.memVector3;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memVector3;
			Protocol.Serialize(vector.x, array, ref num);
			Protocol.Serialize(vector.y, array, ref num);
			Protocol.Serialize(vector.z, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 12);
		}
		return 12;
	}

	// Token: 0x0600AC83 RID: 44163 RVA: 0x003FB00C File Offset: 0x003F920C
	private static object BFLLDNIBMHP(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Vector3 vector = default(Vector3);
		object obj = GOLJCGMCKMG.memVector3;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memVector3, 0, 12);
			int num = 0;
			Protocol.Deserialize(out vector.x, GOLJCGMCKMG.memVector3, ref num);
			Protocol.Deserialize(out vector.y, GOLJCGMCKMG.memVector3, ref num);
			Protocol.Deserialize(out vector.z, GOLJCGMCKMG.memVector3, ref num);
		}
		return vector;
	}

	// Token: 0x0600AC84 RID: 44164 RVA: 0x003FB09C File Offset: 0x003F929C
	private static short LCNMHEMBEFI(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Vector2 vector = (Vector2)CCKPKLEKCFF;
		object obj = GOLJCGMCKMG.memVector2;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memVector2;
			int num = 0;
			Protocol.Serialize(vector.x, array, ref num);
			Protocol.Serialize(vector.y, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 8);
		}
		return 8;
	}

	// Token: 0x0600AC85 RID: 44165 RVA: 0x003FB108 File Offset: 0x003F9308
	private static object HANJLNGFAKP(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Vector2 vector = default(Vector2);
		object obj = GOLJCGMCKMG.memVector2;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memVector2, 0, 8);
			int num = 0;
			Protocol.Deserialize(out vector.x, GOLJCGMCKMG.memVector2, ref num);
			Protocol.Deserialize(out vector.y, GOLJCGMCKMG.memVector2, ref num);
		}
		return vector;
	}

	// Token: 0x0600AC86 RID: 44166 RVA: 0x003FB184 File Offset: 0x003F9384
	private static short PKPCNJJBOJB(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		Quaternion quaternion = (Quaternion)CCKPKLEKCFF;
		object obj = GOLJCGMCKMG.memQuarternion;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memQuarternion;
			int num = 0;
			Protocol.Serialize(quaternion.w, array, ref num);
			Protocol.Serialize(quaternion.x, array, ref num);
			Protocol.Serialize(quaternion.y, array, ref num);
			Protocol.Serialize(quaternion.z, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 16);
		}
		return 16;
	}

	// Token: 0x0600AC87 RID: 44167 RVA: 0x003FB210 File Offset: 0x003F9410
	private static object BNPJAGNEBPN(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		Quaternion quaternion = default(Quaternion);
		object obj = GOLJCGMCKMG.memQuarternion;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memQuarternion, 0, 16);
			int num = 0;
			Protocol.Deserialize(out quaternion.w, GOLJCGMCKMG.memQuarternion, ref num);
			Protocol.Deserialize(out quaternion.x, GOLJCGMCKMG.memQuarternion, ref num);
			Protocol.Deserialize(out quaternion.y, GOLJCGMCKMG.memQuarternion, ref num);
			Protocol.Deserialize(out quaternion.z, GOLJCGMCKMG.memQuarternion, ref num);
		}
		return quaternion;
	}

	// Token: 0x0600AC88 RID: 44168 RVA: 0x003FB2B0 File Offset: 0x003F94B0
	private static short AJKFOONFMDK(StreamBuffer GBJIGMOJIDF, object CCKPKLEKCFF)
	{
		int id = ((PhotonPlayer)CCKPKLEKCFF).ID;
		object obj = GOLJCGMCKMG.memPlayer;
		short result;
		lock (obj)
		{
			byte[] array = GOLJCGMCKMG.memPlayer;
			int num = 0;
			Protocol.Serialize(id, array, ref num);
			GBJIGMOJIDF.Write(array, 0, 4);
			result = 4;
		}
		return result;
	}

	// Token: 0x0600AC89 RID: 44169 RVA: 0x003FB310 File Offset: 0x003F9510
	private static object AEKFJLLFGFB(StreamBuffer OHAAEIEHLMD, short NIEADDJOIEG)
	{
		object obj = GOLJCGMCKMG.memPlayer;
		int key;
		lock (obj)
		{
			OHAAEIEHLMD.Read(GOLJCGMCKMG.memPlayer, 0, (int)NIEADDJOIEG);
			int num = 0;
			Protocol.Deserialize(out key, GOLJCGMCKMG.memPlayer, ref num);
		}
		if (PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(key))
		{
			return PhotonNetwork.JNJJAMNLOHA.mActors[key];
		}
		return null;
	}

	// Token: 0x0400130C RID: 4876
	public static readonly byte[] memVector3 = new byte[12];

	// Token: 0x0400130D RID: 4877
	public static readonly byte[] memVector2 = new byte[8];

	// Token: 0x0400130E RID: 4878
	public static readonly byte[] memQuarternion = new byte[16];

	// Token: 0x0400130F RID: 4879
	public static readonly byte[] memPlayer = new byte[4];

	// Token: 0x04001310 RID: 4880
	[CompilerGenerated]
	private static SerializeStreamMethod BOGJGOAMCHK;

	// Token: 0x04001311 RID: 4881
	[CompilerGenerated]
	private static DeserializeStreamMethod BDPNFNJNEFM;

	// Token: 0x04001312 RID: 4882
	[CompilerGenerated]
	private static SerializeStreamMethod MJKNAFJKDMG;

	// Token: 0x04001313 RID: 4883
	[CompilerGenerated]
	private static DeserializeStreamMethod JENGHDFDLII;

	// Token: 0x04001314 RID: 4884
	[CompilerGenerated]
	private static SerializeStreamMethod BMJHMBNEACI;

	// Token: 0x04001315 RID: 4885
	[CompilerGenerated]
	private static DeserializeStreamMethod EPENHHMDDMB;

	// Token: 0x04001316 RID: 4886
	[CompilerGenerated]
	private static SerializeStreamMethod DNLDPCIINIC;

	// Token: 0x04001317 RID: 4887
	[CompilerGenerated]
	private static DeserializeStreamMethod ILAKDECCIME;
}
