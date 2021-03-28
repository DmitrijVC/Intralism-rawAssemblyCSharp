using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020002E6 RID: 742
internal class OHGAIJCPAJB : PhotonPeer
{
	// Token: 0x0600AD33 RID: 44339 RVA: 0x003FC09C File Offset: 0x003FA29C
	public virtual bool HKCPBMODCGA(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "PlayButton");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[109] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[(byte)-180] = BBACCNINICP;
		}
		return this.OpCustom((byte)-7, dictionary, false, 0);
	}

	// Token: 0x0600AD34 RID: 44340 RVA: 0x003FC100 File Offset: 0x003FA300
	public virtual bool OpAuthenticateOnce(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpAuthenticate()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[221] = GPDFHODMOIJ.Token;
			return this.OpCustom(231, dictionary, true, 0, false);
		}
		if (NLNNMECNKEL == EncryptionMode.DatagramEncryption && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: " + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[195] = (byte)AMKMACFDKEC;
		dictionary[193] = (byte)NLNNMECNKEL;
		dictionary[220] = GKMFHELOOOH;
		dictionary[224] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[210] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[225] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != CustomAuthenticationType.None)
			{
				dictionary[217] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[221] = GPDFHODMOIJ.Token;
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[216] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[214] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return this.OpCustom(231, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600AD35 RID: 44341 RVA: 0x003FC2B8 File Offset: 0x003FA4B8
	public virtual bool CGIPKIOMHCO(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[(byte)-180] = PPNEJGFIAJP;
		return this.OpCustom(121, dictionary, false, 0, true);
	}

	// Token: 0x0600AD36 RID: 44342 RVA: 0x003FC2E8 File Offset: 0x003FA4E8
	public virtual bool BDCHBCMHOGD(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_Value5");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn((DebugLevel)4, "path");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != (LobbyType)5)
		{
			if (this.DebugOut >= (DebugLevel)6)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "_ScreenResolution");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[102] = PKPEDDGHALP.Name;
		dictionary[35] = (byte)PKPEDDGHALP.Type;
		dictionary[121] = INIFMIHFOGD;
		return this.OpCustom((byte)-108, dictionary, true);
	}

	// Token: 0x0600AD37 RID: 44343 RVA: 0x003FC3A8 File Offset: 0x003FA5A8
	public bool OHPJAAGIDJP(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return this.IILDKFGHOHK(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	// Token: 0x0600AD38 RID: 44344 RVA: 0x003FC3B8 File Offset: 0x003FA5B8
	public virtual bool NCAJBJHONIN(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[110] = EEPAJBBCGJK;
		}
		return this.OpCustom((byte)-195, dictionary, false);
	}

	// Token: 0x0600AD39 RID: 44345 RVA: 0x003FC3F0 File Offset: 0x003FA5F0
	public virtual bool DEBJAENPEII(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if (this.DebugOut >= DebugLevel.WARNING)
		{
			base.Listener.DebugReturn((DebugLevel)6, "CameraFilterPack/Blur_GaussianBlur");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)-50] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[(byte)-97] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != MatchmakingMode.FillRoom)
		{
			dictionary[178] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[112] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[(byte)-146] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[(byte)-184] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[(byte)-103] = IFIMMPPLLHI.ExpectedUsers;
		}
		return this.OpCustom((byte)-46, dictionary, false);
	}

	// Token: 0x0600AD3A RID: 44346 RVA: 0x003FC53C File Offset: 0x003FA73C
	public virtual bool MPELLFNHBGN(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= (DebugLevel)7)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_Value3");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[45] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[39] = GPDFHODMOIJ.DGINDFBNNDO();
			return this.OpCustom(30, dictionary, false, 0, true);
		}
		dictionary[57] = GKMFHELOOOH;
		dictionary[145] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[10] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[94] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)193)
			{
				if (!this.CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "_Blue_G");
					return true;
				}
				dictionary[(byte)-162] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[116] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[109] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[79] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = this.OpCustom(173, dictionary, false, 1, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "DPADVER");
		}
		return flag;
	}

	// Token: 0x0600AD3B RID: 44347 RVA: 0x003FC6F0 File Offset: 0x003FA8F0
	public virtual bool OpAuthenticate(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpAuthenticate()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[211] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[221] = GPDFHODMOIJ.Token;
			return this.OpCustom(230, dictionary, true, 0, false);
		}
		dictionary[220] = GKMFHELOOOH;
		dictionary[224] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[210] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[225] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != CustomAuthenticationType.None)
			{
				if (!this.CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.");
					return false;
				}
				dictionary[217] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[221] = GPDFHODMOIJ.Token;
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[216] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[214] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = this.OpCustom(230, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.");
		}
		return flag;
	}

	// Token: 0x0600AD3C RID: 44348 RVA: 0x003FC8A4 File Offset: 0x003FAAA4
	public virtual bool OpGetRegions(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[224] = PPNEJGFIAJP;
		return this.OpCustom(220, dictionary, true, 0, true);
	}

	// Token: 0x0600AD3D RID: 44349 RVA: 0x003FC8D4 File Offset: 0x003FAAD4
	protected void PHIOGBIOJFF(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.FEPNICODBNC(hashtable, null, true);
	}

	// Token: 0x0600AD3E RID: 44350 RVA: 0x003FC8FE File Offset: 0x003FAAFE
	public bool OpSetCustomPropertiesOfRoom(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return this.HFECLDIOHNJ(MJJMNIDHDEC.StripToStringKeys(), null, false);
	}

	// Token: 0x0600AD3F RID: 44351 RVA: 0x003FC90E File Offset: 0x003FAB0E
	public bool INMMEFNAMIP(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return this.APMINOMEBPE(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	// Token: 0x0600AD40 RID: 44352 RVA: 0x003FC920 File Offset: 0x003FAB20
	protected void KFEGIKMAGDH(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.OABLOBEGOPJ(hashtable, null, false);
	}

	// Token: 0x0600AD41 RID: 44353 RVA: 0x003FC94C File Offset: 0x003FAB4C
	public virtual bool FHBKMBGDDMC(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_Value2");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[(byte)-54] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[147] = 1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[21] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[(byte)-193] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[129] = 8;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[15] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[159] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-3] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom(29, dictionary, true);
	}

	// Token: 0x0600AD42 RID: 44354 RVA: 0x003FCAAC File Offset: 0x003FACAC
	public virtual bool BEHIACDGHHC(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_Green_C");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.KHPAOCFGPGM())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[(byte)-146] = PKPEDDGHALP.Name;
			dictionary[142] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom((byte)-63, dictionary, false);
	}

	// Token: 0x0600AD43 RID: 44355 RVA: 0x003FCB23 File Offset: 0x003FAD23
	public virtual bool BBFIHFBJIKE()
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "/");
		}
		return this.OpCustom((byte)-133, null, true);
	}

	// Token: 0x0600AD44 RID: 44356 RVA: 0x003FCB50 File Offset: 0x003FAD50
	private void KFMBAGPOOPO(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[253] = DPODHCMGCPF.IsOpen;
		hashtable[254] = DPODHCMGCPF.IsVisible;
		hashtable[250] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[0]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 0)
		{
			hashtable[byte.MaxValue] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[248] = hashtable;
		int num = 0;
		EKJLPPMJFBB[241] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 2;
			hashtable[249] = true;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 1;
			EKJLPPMJFBB[232] = true;
			EKJLPPMJFBB[235] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[236] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.SuppressRoomEvents)
		{
			num |= 4;
			EKJLPPMJFBB[237] = true;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[204] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.PublishUserId)
		{
			num |= 8;
			EKJLPPMJFBB[239] = true;
		}
		if (DPODHCMGCPF.DeleteNullProperties)
		{
			num |= 16;
		}
		EKJLPPMJFBB[191] = num;
	}

	// Token: 0x0600AD45 RID: 44357 RVA: 0x003FCD30 File Offset: 0x003FAF30
	public virtual bool OBGLEAGJJKK(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return this.OpCustom((byte)-96, dictionary, false);
	}

	// Token: 0x0600AD46 RID: 44358 RVA: 0x003FCD67 File Offset: 0x003FAF67
	public bool ANLEJMLBKLN(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return this.IFBHCMGLLIM(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, true);
	}

	// Token: 0x0600AD47 RID: 44359 RVA: 0x003FC8FE File Offset: 0x003FAAFE
	public bool GHMNEFECONA(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return this.HFECLDIOHNJ(MJJMNIDHDEC.StripToStringKeys(), null, false);
	}

	// Token: 0x0600AD48 RID: 44360 RVA: 0x003FCD78 File Offset: 0x003FAF78
	public virtual bool KLLLCEHNJED(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return this.OpCustom(141, dictionary, false);
	}

	// Token: 0x0600AD49 RID: 44361 RVA: 0x003FCDB0 File Offset: 0x003FAFB0
	public virtual bool OpGetGameList(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList()");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList not sent. Lobby cannot be null.");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != LobbyType.SqlLobby)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList not sent. LobbyType must be SqlLobby.");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[213] = PKPEDDGHALP.Name;
		dictionary[212] = (byte)PKPEDDGHALP.Type;
		dictionary[245] = INIFMIHFOGD;
		return this.OpCustom(217, dictionary, true);
	}

	// Token: 0x0600AD4A RID: 44362 RVA: 0x003FCE70 File Offset: 0x003FB070
	public virtual bool BGIJGNONHEO(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[36] = EEPAJBBCGJK;
		}
		return this.OpCustom(108, dictionary, true);
	}

	// Token: 0x0600AD4B RID: 44363 RVA: 0x003FCEA8 File Offset: 0x003FB0A8
	public virtual bool HGNDNHICNKF(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn((DebugLevel)4, "[Left]");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[144] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[21] = GPDFHODMOIJ.DGINDFBNNDO();
			return this.OpCustom(30, dictionary, true, 1, false);
		}
		dictionary[(byte)-178] = GKMFHELOOOH;
		dictionary[(byte)-194] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[97] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[189] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)168)
			{
				if (!this.LCILDJEFKFI() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "maps.");
					return true;
				}
				dictionary[1] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[(byte)-102] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[(byte)-42] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[(byte)-122] = GPDFHODMOIJ.LPMFOIPADGG();
					}
				}
			}
		}
		bool flag = this.OpCustom((byte)-185, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "id");
		}
		return flag;
	}

	// Token: 0x0600AD4C RID: 44364 RVA: 0x003FD05C File Offset: 0x003FB25C
	public virtual bool HIKIDBBNFBM(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= DebugLevel.WARNING)
		{
			base.Listener.DebugReturn((DebugLevel)7, "Set particles color");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[23] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.PPFIBJOHICJ() != null)
		{
			dictionary[23] = GPDFHODMOIJ.Token;
			return this.OpCustom(163, dictionary, false, 1, true);
		}
		dictionary[167] = GKMFHELOOOH;
		dictionary[159] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-188] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[168] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.AuthType != -86)
			{
				if (!this.CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "CameraFilterPack_RainFX_Anm2");
					return false;
				}
				dictionary[(byte)-120] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[41] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[(byte)-180] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[(byte)-18] = GPDFHODMOIJ.LPMFOIPADGG();
					}
				}
			}
		}
		bool flag = this.OpCustom((byte)-52, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_MainTex2");
		}
		return flag;
	}

	// Token: 0x0600AD4D RID: 44365 RVA: 0x003FD210 File Offset: 0x003FB410
	public virtual bool OpSettings(bool GNAFHNLBPHP)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "OpSettings()");
		}
		this.EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			this.EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		return this.EJELAMOKKKA.Count == 0 || this.OpCustom(218, this.EJELAMOKKKA, true);
	}

	// Token: 0x0600AD4E RID: 44366 RVA: 0x003FD284 File Offset: 0x003FB484
	public virtual bool LHOCCIABPNJ(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		this.EJELAMOKKKA.Clear();
		this.EJELAMOKKKA[(byte)-135] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			this.EJELAMOKKKA[(byte)-10] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != EventCaching.DoNotCache)
			{
				this.EJELAMOKKKA[(byte)-133] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != ReceiverGroup.Others)
			{
				this.EJELAMOKKKA[70] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				this.EJELAMOKKKA[(byte)-39] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				this.EJELAMOKKKA[72] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				this.EJELAMOKKKA[78] = true;
			}
		}
		return this.OpCustom((byte)-164, this.EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	// Token: 0x0600AD4F RID: 44367 RVA: 0x003FD3B9 File Offset: 0x003FB5B9
	public virtual bool LINKHIOFDPB()
	{
		if (this.DebugOut >= (DebugLevel)7)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "Warning: No Shape Curve set for CurveWaveform.cs on ");
		}
		return this.OpCustom((byte)-160, null, false);
	}

	// Token: 0x0600AD50 RID: 44368 RVA: 0x003FD3E8 File Offset: 0x003FB5E8
	protected internal bool LPJIFHNJBMO(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)8)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "Set satellite clockwise rotattion speed");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add((byte)-58, MJJMNIDHDEC);
		dictionary.Add((byte)-23, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(43, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[108] = false;
		}
		return this.OpCustom((byte)-29, dictionary, true, 0, true);
	}

	// Token: 0x0600AD51 RID: 44369 RVA: 0x003FD478 File Offset: 0x003FB678
	protected internal bool LJEFICMOPMO(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfActor()");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(251, FPBCPOGCCBD);
		dictionary.Add(254, KHACEEGCPEP);
		dictionary.Add(250, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(231, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[234] = true;
		}
		return this.OpCustom(252, dictionary, true, 0, false);
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x003FD546 File Offset: 0x003FB746
	internal bool CPIPNMBMBDP
	{
		get
		{
			return base.UsedProtocol == ConnectionProtocol.WebSocketSecure;
		}
	}

	// Token: 0x0600AD53 RID: 44371 RVA: 0x003FD554 File Offset: 0x003FB754
	public virtual bool BCCNNNLOADO(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn((DebugLevel)6, "/../");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[(byte)-147] = false;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[(byte)-94] = GPDFHODMOIJ.IFKGNPNPDDI();
			return this.OpCustom(94, dictionary, true, 0, false);
		}
		dictionary[(byte)-49] = GKMFHELOOOH;
		dictionary[(byte)-35] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-16] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[(byte)-131] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if ((int)GPDFHODMOIJ.AuthType != -86)
			{
				if (!this.LCILDJEFKFI() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "Left Stick Click");
					return true;
				}
				dictionary[(byte)-30] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[(byte)-189] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[72] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[67] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = this.OpCustom((byte)-198, dictionary, true, 1, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_Distance");
		}
		return flag;
	}

	// Token: 0x0600AD54 RID: 44372 RVA: 0x003FD546 File Offset: 0x003FB746
	internal bool LCILDJEFKFI()
	{
		return base.UsedProtocol == ConnectionProtocol.WebSocketSecure;
	}

	// Token: 0x0600AD55 RID: 44373 RVA: 0x003FD708 File Offset: 0x003FB908
	public virtual bool HFBOBEKKBHK(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[130] = PPNEJGFIAJP;
		return this.OpCustom((byte)-185, dictionary, true, 0, true);
	}

	// Token: 0x0600AD56 RID: 44374 RVA: 0x003FD738 File Offset: 0x003FB938
	public virtual bool JCJBOMAOPIP(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "y");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= DebugLevel.OFF)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, ".lastCheckpoint.penaltyScore");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != (LobbyType)4)
		{
			if (this.DebugOut >= DebugLevel.ALL)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "CameraFilterPack/TV_WideScreenHV");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[172] = PKPEDDGHALP.Name;
		dictionary[(byte)-34] = (byte)PKPEDDGHALP.Type;
		dictionary[108] = INIFMIHFOGD;
		return this.OpCustom((byte)-197, dictionary, false);
	}

	// Token: 0x0600AD57 RID: 44375 RVA: 0x003FD7F8 File Offset: 0x003FB9F8
	public virtual bool GAOMBMOHHCP(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn((DebugLevel)7, "' ping: ");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[133] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[(byte)-178] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != MatchmakingMode.FillRoom)
		{
			dictionary[156] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[18] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[(byte)-82] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[(byte)-139] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[2] = IFIMMPPLLHI.ExpectedUsers;
		}
		return this.OpCustom(43, dictionary, false);
	}

	// Token: 0x0600AD58 RID: 44376 RVA: 0x003FD944 File Offset: 0x003FBB44
	protected internal bool FEPNICODBNC(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn((DebugLevel)7, "CameraFilterPack/Oculus_ThermaVision");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add((byte)-172, MJJMNIDHDEC);
		dictionary.Add((byte)-118, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(90, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-68] = true;
		}
		return this.OpCustom((byte)-128, dictionary, true, 1, false);
	}

	// Token: 0x0600AD59 RID: 44377 RVA: 0x003FD9D4 File Offset: 0x003FBBD4
	public virtual bool JCHOHGKONJI(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= DebugLevel.WARNING)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "CameraFilterPack/Distortion_Dream2");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.PPFIBJOHICJ() != null)
		{
			dictionary[17] = GPDFHODMOIJ.DGINDFBNNDO();
			return this.OpCustom((byte)-168, dictionary, false, 1, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-123) && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("ConfigVersionSlider" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[(byte)-105] = (byte)AMKMACFDKEC;
		dictionary[119] = (byte)NLNNMECNKEL;
		dictionary[165] = GKMFHELOOOH;
		dictionary[185] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-175] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[35] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if ((int)GPDFHODMOIJ.NKIEPEALJIB() != -162)
			{
				dictionary[(byte)-182] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[(byte)-88] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[40] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[154] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return this.OpCustom((byte)-16, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600AD5A RID: 44378 RVA: 0x003FDB8C File Offset: 0x003FBD8C
	public virtual bool EDLLPOONPPO()
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn((DebugLevel)8, "OK");
		}
		return this.OpCustom(74, null, true);
	}

	// Token: 0x0600AD5B RID: 44379 RVA: 0x003FDBB8 File Offset: 0x003FBDB8
	public virtual bool OIOPKLGHDGM(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		this.EJELAMOKKKA.Clear();
		this.EJELAMOKKKA[(byte)-169] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			this.EJELAMOKKKA[104] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != EventCaching.DoNotCache)
			{
				this.EJELAMOKKKA[(byte)-160] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != ReceiverGroup.Others)
			{
				this.EJELAMOKKKA[83] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				this.EJELAMOKKKA[16] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				this.EJELAMOKKKA[(byte)-165] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				this.EJELAMOKKKA[111] = false;
			}
		}
		return this.OpCustom((byte)-57, this.EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	// Token: 0x0600AD5C RID: 44380 RVA: 0x003FDCF0 File Offset: 0x003FBEF0
	protected internal bool CKFJPBAJPHC(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn((DebugLevel)6, "SetTrailZoomSpeed");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if (this.DebugOut >= DebugLevel.WARNING)
			{
				base.Listener.DebugReturn(DebugLevel.OFF, "st");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add((byte)-141, FPBCPOGCCBD);
		dictionary.Add(149, KHACEEGCPEP);
		dictionary.Add(81, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(195, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-33] = false;
		}
		return this.OpCustom(6, dictionary, false, 1, false);
	}

	// Token: 0x0600AD5D RID: 44381 RVA: 0x003FDDC0 File Offset: 0x003FBFC0
	public virtual bool FBFFAGLHBCB(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn((DebugLevel)4, "CameraFilterPack/BlurHole");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[193] = GPDFHODMOIJ.PPFIBJOHICJ();
			return this.OpCustom((byte)-170, dictionary, true, 1, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)64 && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("_Speed" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[(byte)-84] = (byte)AMKMACFDKEC;
		dictionary[9] = (byte)NLNNMECNKEL;
		dictionary[(byte)-114] = GKMFHELOOOH;
		dictionary[28] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[96] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[(byte)-65] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.NKIEPEALJIB() != -165)
			{
				dictionary[(byte)-192] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[55] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[(byte)-52] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[32] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return this.OpCustom(6, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600AD5E RID: 44382 RVA: 0x003FDF78 File Offset: 0x003FC178
	protected internal bool HPGLPPCPEJC(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn((DebugLevel)7, "tintColor");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if (this.DebugOut >= (DebugLevel)4)
			{
				base.Listener.DebugReturn(DebugLevel.WARNING, "GroupNameText");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(148, FPBCPOGCCBD);
		dictionary.Add(50, KHACEEGCPEP);
		dictionary.Add((byte)-16, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add((byte)-83, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-173] = true;
		}
		return this.OpCustom((byte)-188, dictionary, true, 0, false);
	}

	// Token: 0x0600AD5F RID: 44383 RVA: 0x003FE048 File Offset: 0x003FC248
	protected void HPDAKLMDBIC(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.OABLOBEGOPJ(hashtable, null, false);
	}

	// Token: 0x0600AD60 RID: 44384 RVA: 0x003FE074 File Offset: 0x003FC274
	public virtual bool KLGCDNLPLAO(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return this.OpCustom(76, dictionary, false);
	}

	// Token: 0x0600AD61 RID: 44385 RVA: 0x003FE0AB File Offset: 0x003FC2AB
	public virtual bool PNOCMLPFNBI()
	{
		if (this.DebugOut >= DebugLevel.WARNING)
		{
			base.Listener.DebugReturn((DebugLevel)4, " PhotonView: ");
		}
		return this.OpCustom((byte)-175, null, false);
	}

	// Token: 0x0600AD62 RID: 44386 RVA: 0x003FE0D8 File Offset: 0x003FC2D8
	public virtual bool OJFFLJAHOKP(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn((DebugLevel)8, "#exit");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= (DebugLevel)4)
			{
				base.Listener.DebugReturn(DebugLevel.OFF, "Editor/");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.AsyncRandomLobby)
		{
			if (this.DebugOut >= (DebugLevel)4)
			{
				base.Listener.DebugReturn((DebugLevel)6, "_FgOverlap");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[109] = PKPEDDGHALP.Name;
		dictionary[104] = (byte)PKPEDDGHALP.Type;
		dictionary[(byte)-6] = INIFMIHFOGD;
		return this.OpCustom(74, dictionary, true);
	}

	// Token: 0x0600AD63 RID: 44387 RVA: 0x003FE198 File Offset: 0x003FC398
	public virtual bool HFKAJEBEDIL(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn((DebugLevel)8, "settings.enablehitsoundsinnormal");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.PPFIBJOHICJ() != null)
		{
			dictionary[109] = GPDFHODMOIJ.Token;
			return this.OpCustom(18, dictionary, false, 0, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-85) && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("Right Stick Click" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[(byte)-160] = (byte)AMKMACFDKEC;
		dictionary[198] = (byte)NLNNMECNKEL;
		dictionary[145] = GKMFHELOOOH;
		dictionary[(byte)-108] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-97] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[(byte)-139] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)119)
			{
				dictionary[77] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[21] = GPDFHODMOIJ.IFKGNPNPDDI();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[(byte)-81] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[(byte)-50] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return this.OpCustom(36, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600AD64 RID: 44388 RVA: 0x003FE350 File Offset: 0x003FC550
	public bool GIPNIFODHCA(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return this.HPGLPPCPEJC(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, true);
	}

	// Token: 0x0600AD65 RID: 44389 RVA: 0x003FE364 File Offset: 0x003FC564
	public virtual bool OpJoinRoom(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinRoom()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[byte.MaxValue] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[215] = 1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[213] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[212] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[215] = 3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[238] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[249] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[250] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom(226, dictionary, true);
	}

	// Token: 0x0600AD66 RID: 44390 RVA: 0x003FE4C4 File Offset: 0x003FC6C4
	public virtual bool BBIOIEGCLDJ(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_ScreenResolution");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[(byte)-177] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[(byte)-22] = GPDFHODMOIJ.IFKGNPNPDDI();
			return this.OpCustom((byte)-97, dictionary, false, 0, true);
		}
		dictionary[122] = GKMFHELOOOH;
		dictionary[(byte)-158] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[193] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[(byte)-133] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)198)
			{
				if (!this.LCILDJEFKFI() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, "ItemsCountText");
					return true;
				}
				dictionary[26] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.IFKGNPNPDDI()))
				{
					dictionary[(byte)-141] = GPDFHODMOIJ.IFKGNPNPDDI();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[(byte)-69] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.AuthPostData != null)
					{
						dictionary[102] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		bool flag = this.OpCustom((byte)-103, dictionary, false, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "L1");
		}
		return flag;
	}

	// Token: 0x0600AD67 RID: 44391 RVA: 0x003FE678 File Offset: 0x003FC878
	public virtual bool KOCJEDALDDL(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn((DebugLevel)4, "_SmoothEnd");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 0)
		{
			hashtable[11] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[(byte)-27] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != MatchmakingMode.FillRoom)
		{
			dictionary[0] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[22] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[(byte)-81] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[157] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[113] = IFIMMPPLLHI.ExpectedUsers;
		}
		return this.OpCustom((byte)-6, dictionary, true);
	}

	// Token: 0x0600AD68 RID: 44392 RVA: 0x003FE7C4 File Offset: 0x003FC9C4
	protected internal bool HFECLDIOHNJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfRoom()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(251, MJJMNIDHDEC);
		dictionary.Add(250, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(231, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[234] = true;
		}
		return this.OpCustom(252, dictionary, true, 0, false);
	}

	// Token: 0x0600AD69 RID: 44393 RVA: 0x003FE854 File Offset: 0x003FCA54
	protected internal bool IILDKFGHOHK(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "_Value4");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(72, MJJMNIDHDEC);
		dictionary.Add(130, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(133, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[157] = true;
		}
		return this.OpCustom((byte)-182, dictionary, false, 1, true);
	}

	// Token: 0x0600AD6A RID: 44394 RVA: 0x003FE8E4 File Offset: 0x003FCAE4
	protected internal bool FMDMPEMOAAB(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "menu.enableselectormusic");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(11, MJJMNIDHDEC);
		dictionary.Add((byte)-119, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add((byte)-122, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-75] = true;
		}
		return this.OpCustom(189, dictionary, false, 1, true);
	}

	// Token: 0x0600AD6B RID: 44395 RVA: 0x003FE974 File Offset: 0x003FCB74
	public virtual bool MGCPCNDACGG(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_Value7");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.IsDefault)
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[39] = PKPEDDGHALP.Name;
			dictionary[91] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom((byte)-100, dictionary, false);
	}

	// Token: 0x0600AD6C RID: 44396 RVA: 0x003FE9EC File Offset: 0x003FCBEC
	public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinRandomRoom()");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 0)
		{
			hashtable[byte.MaxValue] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[248] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != MatchmakingMode.FillRoom)
		{
			dictionary[223] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[213] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[212] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[245] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[238] = IFIMMPPLLHI.ExpectedUsers;
		}
		return this.OpCustom(225, dictionary, true);
	}

	// Token: 0x0600AD6D RID: 44397 RVA: 0x003FEB38 File Offset: 0x003FCD38
	public virtual bool PIEPJOLEACH(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn((DebugLevel)6, "maps.");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[96] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[106] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[99] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[73] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[70] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-9] = true;
			}
			this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return this.OpCustom((byte)-155, dictionary, false);
	}

	// Token: 0x0600AD6E RID: 44398 RVA: 0x003FEC68 File Offset: 0x003FCE68
	public virtual bool IPOIGDNKHJN(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "z");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[121] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[123] = 1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[(byte)-185] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[(byte)-133] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[4] = 0;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[2] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[21] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[53] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom((byte)-45, dictionary, false);
	}

	// Token: 0x0600AD6F RID: 44399 RVA: 0x003FEDC8 File Offset: 0x003FCFC8
	protected void DLKJFOOLIFF(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.OABLOBEGOPJ(hashtable, null, false);
	}

	// Token: 0x0600AD70 RID: 44400 RVA: 0x003FEDF4 File Offset: 0x003FCFF4
	public virtual bool FKFFPHFNPLP(bool GNAFHNLBPHP)
	{
		if (this.DebugOut >= (DebugLevel)8)
		{
			base.Listener.DebugReturn((DebugLevel)4, "SpawnObj");
		}
		this.EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			this.EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		return this.EJELAMOKKKA.Count != 0 && this.OpCustom(77, this.EJELAMOKKKA, false);
	}

	// Token: 0x0600AD71 RID: 44401 RVA: 0x003FEE68 File Offset: 0x003FD068
	protected internal bool BEOJCMLIENM(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "#");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(159, MJJMNIDHDEC);
		dictionary.Add((byte)-132, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add((byte)-77, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-110] = true;
		}
		return this.OpCustom((byte)-81, dictionary, false, 0, false);
	}

	// Token: 0x0600AD72 RID: 44402 RVA: 0x003FEEF8 File Offset: 0x003FD0F8
	public virtual bool JLLCPJGDHOL(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn((DebugLevel)6, "Object ID. Case-Sensitive");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[87] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[(byte)-195] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[121] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[(byte)-45] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[88] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[30] = true;
			}
			this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return this.OpCustom((byte)-2, dictionary, true);
	}

	// Token: 0x0600AD73 RID: 44403 RVA: 0x003FF028 File Offset: 0x003FD228
	protected internal bool JBBEGBKFAMH(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn((DebugLevel)8, "Texture3");
		}
		if (KHACEEGCPEP <= 0 || FPBCPOGCCBD == null)
		{
			if (this.DebugOut >= DebugLevel.ERROR)
			{
				base.Listener.DebugReturn((DebugLevel)7, ",");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add((byte)-98, FPBCPOGCCBD);
		dictionary.Add((byte)-177, KHACEEGCPEP);
		dictionary.Add((byte)-50, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(189, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-5] = true;
		}
		return this.OpCustom(80, dictionary, false, 1, true);
	}

	// Token: 0x0600AD74 RID: 44404 RVA: 0x003FF0F6 File Offset: 0x003FD2F6
	public OHGAIJCPAJB(IPhotonPeerListener LONKELGPCJD, ConnectionProtocol MBOEJGPGFJB) : this(MBOEJGPGFJB)
	{
		base.Listener = LONKELGPCJD;
	}

	// Token: 0x0600AD75 RID: 44405 RVA: 0x003FF108 File Offset: 0x003FD308
	public virtual bool FELJKHFIBFD(bool GNAFHNLBPHP)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "steamid");
		}
		this.EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			this.EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		return this.EJELAMOKKKA.Count != 0 && this.OpCustom(160, this.EJELAMOKKKA, true);
	}

	// Token: 0x0600AD76 RID: 44406 RVA: 0x003FF17C File Offset: 0x003FD37C
	protected internal bool NOJCGHELIEK(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)7)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "CameraFilterPack/Colors_BleachBypass");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(36, MJJMNIDHDEC);
		dictionary.Add((byte)-118, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(66, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[128] = true;
		}
		return this.OpCustom(9, dictionary, true, 1, false);
	}

	// Token: 0x0600AD77 RID: 44407 RVA: 0x003FF20C File Offset: 0x003FD40C
	public virtual bool OFGIIHGFNCN(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn((DebugLevel)8, "Clear Environment");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[(byte)-196] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[36] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[(byte)-171] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[117] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[(byte)-179] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-18] = true;
			}
			this.PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return this.OpCustom((byte)-126, dictionary, true);
	}

	// Token: 0x0600AD78 RID: 44408 RVA: 0x003FF33C File Offset: 0x003FD53C
	public virtual bool PKLLHBHANGC(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return this.OpCustom((byte)-33, dictionary, false);
	}

	// Token: 0x0600AD79 RID: 44409 RVA: 0x003FF374 File Offset: 0x003FD574
	protected internal bool EBELCLCCFFJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn((DebugLevel)7, "CameraFilterPack/Blend2Camera_Luminosity");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(91, MJJMNIDHDEC);
		dictionary.Add((byte)-55, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(25, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-45] = false;
		}
		return this.OpCustom(145, dictionary, true, 0, true);
	}

	// Token: 0x0600AD7A RID: 44410 RVA: 0x003FF404 File Offset: 0x003FD604
	public virtual bool OpJoinLobby(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinLobby()");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.IsDefault)
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[213] = PKPEDDGHALP.Name;
			dictionary[212] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom(229, dictionary, true);
	}

	// Token: 0x0600AD7B RID: 44411 RVA: 0x003FF47C File Offset: 0x003FD67C
	private void PJMBJJMOILI(Dictionary<byte, object> EKJLPPMJFBB, RoomOptions DPODHCMGCPF)
	{
		if (DPODHCMGCPF == null)
		{
			DPODHCMGCPF = new RoomOptions();
		}
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-88] = DPODHCMGCPF.IsOpen;
		hashtable[(byte)-187] = DPODHCMGCPF.PKADEGKJHOO();
		hashtable[186] = ((DPODHCMGCPF.CustomRoomPropertiesForLobby != null) ? DPODHCMGCPF.CustomRoomPropertiesForLobby : new string[0]);
		hashtable.MergeStringKeys(DPODHCMGCPF.CustomRoomProperties);
		if (DPODHCMGCPF.MaxPlayers > 1)
		{
			hashtable[(byte)-185] = DPODHCMGCPF.MaxPlayers;
		}
		EKJLPPMJFBB[(byte)-177] = hashtable;
		int num = 1;
		EKJLPPMJFBB[(byte)-123] = DPODHCMGCPF.CleanupCacheOnLeave;
		if (DPODHCMGCPF.CleanupCacheOnLeave)
		{
			num |= 7;
			hashtable[(byte)-165] = false;
		}
		if (DPODHCMGCPF.PlayerTtl > 0 || DPODHCMGCPF.PlayerTtl == -1)
		{
			num |= 0;
			EKJLPPMJFBB[(byte)-66] = true;
			EKJLPPMJFBB[158] = DPODHCMGCPF.PlayerTtl;
		}
		if (DPODHCMGCPF.EmptyRoomTtl > 0)
		{
			EKJLPPMJFBB[109] = DPODHCMGCPF.EmptyRoomTtl;
		}
		if (DPODHCMGCPF.BDEFAIOFJDI())
		{
			num |= 5;
			EKJLPPMJFBB[0] = false;
		}
		if (DPODHCMGCPF.Plugins != null)
		{
			EKJLPPMJFBB[(byte)-36] = DPODHCMGCPF.Plugins;
		}
		if (DPODHCMGCPF.KKMHCPJLBAB())
		{
			num |= 2;
			EKJLPPMJFBB[(byte)-191] = false;
		}
		if (DPODHCMGCPF.OJIGPFICGKB())
		{
			num |= 99;
		}
		EKJLPPMJFBB[156] = num;
	}

	// Token: 0x0600AD7C RID: 44412 RVA: 0x003FF65C File Offset: 0x003FD85C
	public virtual bool CKBCKDPCODK(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return this.OpCustom(12, dictionary, false);
	}

	// Token: 0x0600AD7D RID: 44413 RVA: 0x003FF694 File Offset: 0x003FD894
	public virtual bool JLOPOLBOJBG(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= (DebugLevel)8)
		{
			base.Listener.DebugReturn((DebugLevel)6, "settings.fps");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= DebugLevel.ERROR)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "_Value2");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != (LobbyType)5)
		{
			if (this.DebugOut >= (DebugLevel)7)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "ScrollPanel");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[(byte)-169] = PKPEDDGHALP.Name;
		dictionary[10] = (byte)PKPEDDGHALP.Type;
		dictionary[152] = INIFMIHFOGD;
		return this.OpCustom((byte)-170, dictionary, true);
	}

	// Token: 0x0600AD7E RID: 44414 RVA: 0x003FF754 File Offset: 0x003FD954
	internal bool JKAKCGOLJAE()
	{
		return base.UsedProtocol == ConnectionProtocol.Tcp;
	}

	// Token: 0x0600AD7F RID: 44415 RVA: 0x003FF760 File Offset: 0x003FD960
	public virtual bool PBIHOMIGJPG(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_TimeX");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[105] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[123] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[47] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[148] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[(byte)-175] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-173] = true;
			}
			this.PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return this.OpCustom((byte)-197, dictionary, false);
	}

	// Token: 0x0600AD80 RID: 44416 RVA: 0x003FF890 File Offset: 0x003FDA90
	protected internal bool CADDOMOCLIJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_ReprojectionMatrix");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(45, MJJMNIDHDEC);
		dictionary.Add(156, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(133, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-134] = true;
		}
		return this.OpCustom(2, dictionary, false, 0, true);
	}

	// Token: 0x0600AD81 RID: 44417 RVA: 0x003FF920 File Offset: 0x003FDB20
	public virtual bool OIPBLLHGHNB(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "_Near");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[158] = false;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[(byte)-116] = GPDFHODMOIJ.IFKGNPNPDDI();
			return this.OpCustom(165, dictionary, true, 1, true);
		}
		dictionary[(byte)-54] = GKMFHELOOOH;
		dictionary[44] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-144] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[32] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)156)
			{
				if (!this.LEBELEEEIDO() && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "achievements.21.progress");
					return true;
				}
				dictionary[85] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[(byte)-99] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[166] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[(byte)-152] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = this.OpCustom((byte)-135, dictionary, true, 0, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "[EditorEvent] Exception: ");
		}
		return flag;
	}

	// Token: 0x0600AD82 RID: 44418 RVA: 0x003FFAD4 File Offset: 0x003FDCD4
	protected void AGIKJINNDPN(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.HFECLDIOHNJ(hashtable, null, false);
	}

	// Token: 0x0600AD83 RID: 44419 RVA: 0x003FFB00 File Offset: 0x003FDD00
	public virtual bool HBAKDBPIBJE(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn((DebugLevel)6, "CameraFilterPack/Color_RGB");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[21] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[12] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != MatchmakingMode.FillRoom)
		{
			dictionary[(byte)-145] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[(byte)-16] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[(byte)-186] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[(byte)-84] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 1)
		{
			dictionary[(byte)-102] = IFIMMPPLLHI.ExpectedUsers;
		}
		return this.OpCustom((byte)-92, dictionary, true);
	}

	// Token: 0x0600AD84 RID: 44420 RVA: 0x003FFC4B File Offset: 0x003FDE4B
	public bool OpSetCustomPropertiesOfActor(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return this.LJEFICMOPMO(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, false);
	}

	// Token: 0x0600AD85 RID: 44421 RVA: 0x003FFC5C File Offset: 0x003FDE5C
	public virtual bool ADKPCNKKLCI(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_MaxRadiusOrKInPaper");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[(byte)-83] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[(byte)-169] = 0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[(byte)-61] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[(byte)-45] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[(byte)-94] = 0;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[11] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[87] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-42] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom((byte)-64, dictionary, false);
	}

	// Token: 0x0600AD86 RID: 44422 RVA: 0x003FFDBC File Offset: 0x003FDFBC
	public virtual bool LEMMBMIBBMF(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[105] = PPNEJGFIAJP;
		return this.OpCustom(136, dictionary, true, 0, true);
	}

	// Token: 0x0600AD87 RID: 44423 RVA: 0x003FFDEC File Offset: 0x003FDFEC
	public virtual bool OpCreateRoom(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpCreateRoom()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[byte.MaxValue] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[213] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[212] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[238] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[249] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[250] = true;
			}
			this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return this.OpCustom(227, dictionary, true);
	}

	// Token: 0x0600AD88 RID: 44424 RVA: 0x003FFC4B File Offset: 0x003FDE4B
	public bool OOOPBJPEFLP(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return this.LJEFICMOPMO(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, false);
	}

	// Token: 0x0600AD89 RID: 44425 RVA: 0x003FFF1C File Offset: 0x003FE11C
	public virtual bool GHDAINIGOMP(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_History3Weight");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[58] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[27] = 0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[(byte)-167] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[(byte)-128] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[56] = 3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[112] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[149] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-153] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom((byte)-120, dictionary, false);
	}

	// Token: 0x0600AD8A RID: 44426 RVA: 0x0040007C File Offset: 0x003FE27C
	public virtual bool AMPLECEGLLN(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn((DebugLevel)4, "LevelURLInputField");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[74] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[93] = BBACCNINICP;
		}
		return this.OpCustom((byte)-5, dictionary, true, 0);
	}

	// Token: 0x0600AD8B RID: 44427 RVA: 0x004000E0 File Offset: 0x003FE2E0
	protected internal bool DGNOGCOIPIA(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "turn: {0:0}");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(6, MJJMNIDHDEC);
		dictionary.Add((byte)-165, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(152, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-102] = true;
		}
		return this.OpCustom(97, dictionary, true, 1, false);
	}

	// Token: 0x0600AD8C RID: 44428 RVA: 0x00400170 File Offset: 0x003FE370
	public virtual bool FJCMOCPLACC(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, ":");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.MAKPKDLNCDO())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[63] = PKPEDDGHALP.Name;
			dictionary[28] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom(42, dictionary, true);
	}

	// Token: 0x0600AD8D RID: 44429 RVA: 0x004001E8 File Offset: 0x003FE3E8
	public virtual bool OpRaiseEvent(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		this.EJELAMOKKKA.Clear();
		this.EJELAMOKKKA[244] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			this.EJELAMOKKKA[245] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != EventCaching.DoNotCache)
			{
				this.EJELAMOKKKA[247] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != ReceiverGroup.Others)
			{
				this.EJELAMOKKKA[246] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				this.EJELAMOKKKA[240] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				this.EJELAMOKKKA[252] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				this.EJELAMOKKKA[234] = true;
			}
		}
		return this.OpCustom(253, this.EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	// Token: 0x0600AD8E RID: 44430 RVA: 0x00400320 File Offset: 0x003FE520
	public virtual bool GAGAEBLPPFM(bool GNAFHNLBPHP)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn((DebugLevel)8, "[SERVER] Selected map: ");
		}
		this.EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			this.EJELAMOKKKA[0] = GNAFHNLBPHP;
		}
		return this.EJELAMOKKKA.Count == 0 || this.OpCustom((byte)-100, this.EJELAMOKKKA, false);
	}

	// Token: 0x0600AD8F RID: 44431 RVA: 0x00400394 File Offset: 0x003FE594
	public virtual bool KBEICOFLCFC(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn((DebugLevel)8, "PPI: ");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= (DebugLevel)6)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "Set Arcs Speed");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.SqlLobby)
		{
			if (this.DebugOut >= DebugLevel.WARNING)
			{
				base.Listener.DebugReturn(DebugLevel.OFF, "_DotSize");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[15] = PKPEDDGHALP.Name;
		dictionary[91] = (byte)PKPEDDGHALP.Type;
		dictionary[47] = INIFMIHFOGD;
		return this.OpCustom((byte)-76, dictionary, true);
	}

	// Token: 0x0600AD90 RID: 44432 RVA: 0x00400454 File Offset: 0x003FE654
	public virtual bool DMIKNEPMMJB(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "#ok");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.LJHKKOEPODN())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[111] = PKPEDDGHALP.Name;
			dictionary[(byte)-3] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom(128, dictionary, false);
	}

	// Token: 0x0600AD91 RID: 44433 RVA: 0x004004CC File Offset: 0x003FE6CC
	public virtual bool HGGNBHOELEK(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[0] = MIMEHFLKIIG;
		}
		return this.OpCustom((byte)-2, dictionary, true);
	}

	// Token: 0x0600AD92 RID: 44434 RVA: 0x00400504 File Offset: 0x003FE704
	public virtual bool LHFNDEPFJAF(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		this.EJELAMOKKKA.Clear();
		this.EJELAMOKKKA[(byte)-7] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			this.EJELAMOKKKA[(byte)-129] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != EventCaching.DoNotCache)
			{
				this.EJELAMOKKKA[67] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != ReceiverGroup.Others)
			{
				this.EJELAMOKKKA[(byte)-59] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				this.EJELAMOKKKA[25] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				this.EJELAMOKKKA[(byte)-182] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				this.EJELAMOKKKA[(byte)-83] = true;
			}
		}
		return this.OpCustom((byte)-110, this.EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	// Token: 0x0600AD93 RID: 44435 RVA: 0x0040063C File Offset: 0x003FE83C
	public virtual bool OIPJGPKILNF(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "/../");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.IFKGNPNPDDI() != null)
		{
			dictionary[(byte)-92] = GPDFHODMOIJ.IFKGNPNPDDI();
			return this.OpCustom((byte)-62, dictionary, false, 0, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)12 && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("CameraFilterPack/Drawing_BluePrint" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[(byte)-59] = (byte)AMKMACFDKEC;
		dictionary[(byte)-78] = (byte)NLNNMECNKEL;
		dictionary[39] = GKMFHELOOOH;
		dictionary[87] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-57] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[(byte)-74] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)109)
			{
				dictionary[165] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.PPFIBJOHICJ()))
				{
					dictionary[20] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[149] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[(byte)-185] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return this.OpCustom(22, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600AD94 RID: 44436 RVA: 0x004007F4 File Offset: 0x003FE9F4
	public virtual bool MBMAGCCPKPI(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, bool CCCKLALIIKO)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn((DebugLevel)6, "_Convolved_TexelSize");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (CCCKLALIIKO)
		{
			dictionary[(byte)-100] = true;
		}
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[173] = GPDFHODMOIJ.DGINDFBNNDO();
			return this.OpCustom((byte)-152, dictionary, false, 1, true);
		}
		dictionary[(byte)-15] = GKMFHELOOOH;
		dictionary[(byte)-134] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-153] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[84] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.AuthType != -167)
			{
				if (!this.CPIPNMBMBDP && !base.IsEncryptionAvailable)
				{
					base.Listener.DebugReturn(DebugLevel.OFF, "[CraftingPanel] Init");
					return true;
				}
				dictionary[(byte)-149] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.IFKGNPNPDDI()))
				{
					dictionary[(byte)-103] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[(byte)-79] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[99] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		bool flag = this.OpCustom((byte)-183, dictionary, true, 1, base.IsEncryptionAvailable);
		if (!flag)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "CameraFilterPack_VHS1");
		}
		return flag;
	}

	// Token: 0x0600AD95 RID: 44437 RVA: 0x004009A8 File Offset: 0x003FEBA8
	protected internal bool APMINOMEBPE(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_NoiseAmount");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add((byte)-81, MJJMNIDHDEC);
		dictionary.Add((byte)-107, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add(17, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-79] = false;
		}
		return this.OpCustom((byte)-19, dictionary, false, 0, true);
	}

	// Token: 0x0600AD96 RID: 44438 RVA: 0x00400A38 File Offset: 0x003FEC38
	public virtual bool IHGINBNOBKB(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, " - {0}");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[(byte)-167] = GPDFHODMOIJ.IFKGNPNPDDI();
			return this.OpCustom(113, dictionary, false, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-38) && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("InfoText" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Tcp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[(byte)-1] = (byte)AMKMACFDKEC;
		dictionary[(byte)-130] = (byte)NLNNMECNKEL;
		dictionary[(byte)-47] = GKMFHELOOOH;
		dictionary[(byte)-180] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[21] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[147] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)129)
			{
				dictionary[(byte)-15] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[(byte)-34] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[5] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[30] = GPDFHODMOIJ.LPMFOIPADGG();
					}
				}
			}
		}
		return this.OpCustom(175, dictionary, true, 1, base.IsEncryptionAvailable);
	}

	// Token: 0x0600AD97 RID: 44439 RVA: 0x00400BF0 File Offset: 0x003FEDF0
	public virtual bool KNJOPJNBFCA(bool GNAFHNLBPHP)
	{
		if (this.DebugOut >= (DebugLevel)8)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_TimeX");
		}
		this.EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			this.EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		return this.EJELAMOKKKA.Count == 0 || this.OpCustom(131, this.EJELAMOKKKA, true);
	}

	// Token: 0x0600AD98 RID: 44440 RVA: 0x00400C64 File Offset: 0x003FEE64
	public virtual bool CDDNMNDHELA(bool GNAFHNLBPHP)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn((DebugLevel)6, "CameraFilterPack/Drawing_Curve");
		}
		this.EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			this.EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		return this.EJELAMOKKKA.Count != 0 && this.OpCustom(97, this.EJELAMOKKKA, true);
	}

	// Token: 0x0600AD99 RID: 44441 RVA: 0x00400CD8 File Offset: 0x003FEED8
	public virtual bool JODDCFJILCH(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[(byte)-200] = EEPAJBBCGJK;
		}
		return this.OpCustom(57, dictionary, false);
	}

	// Token: 0x0600AD9A RID: 44442 RVA: 0x00400D0F File Offset: 0x003FEF0F
	public virtual bool IHIKIFHBOJA()
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn((DebugLevel)8, "[");
		}
		return this.OpCustom(104, null, false);
	}

	// Token: 0x0600AD9B RID: 44443 RVA: 0x00400D3C File Offset: 0x003FEF3C
	public virtual bool LDBKPCIKPDD(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn((DebugLevel)7, "_ChromaticAberration");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= (DebugLevel)7)
			{
				base.Listener.DebugReturn((DebugLevel)4, "EventMenu");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.SqlLobby)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn((DebugLevel)6, "#{0:00} '{1}'{2} {3}");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[145] = PKPEDDGHALP.Name;
		dictionary[(byte)-2] = (byte)PKPEDDGHALP.Type;
		dictionary[(byte)-136] = INIFMIHFOGD;
		return this.OpCustom((byte)-177, dictionary, false);
	}

	// Token: 0x0600AD9C RID: 44444 RVA: 0x00400DFC File Offset: 0x003FEFFC
	public bool LPLFNMFBHIP(Hashtable MJJMNIDHDEC, bool GJJDNCHDGOL, byte LBOCMOFLPJD)
	{
		return this.FEPNICODBNC(MJJMNIDHDEC.StripToStringKeys(), null, true);
	}

	// Token: 0x0600AD9D RID: 44445 RVA: 0x00400E0C File Offset: 0x003FF00C
	public virtual bool NOIJCDINDLL(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_Distortion");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.NLPINAKJLPF())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[(byte)-165] = PKPEDDGHALP.Name;
			dictionary[(byte)-19] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom(190, dictionary, false);
	}

	// Token: 0x0600AD9E RID: 44446 RVA: 0x00400E84 File Offset: 0x003FF084
	public virtual bool BGGJHBKFGPD(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return this.OpCustom(22, dictionary, true);
	}

	// Token: 0x0600AD9F RID: 44447 RVA: 0x00400EBC File Offset: 0x003FF0BC
	public virtual bool OpLeaveRoom(bool EEPAJBBCGJK)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (EEPAJBBCGJK)
		{
			dictionary[233] = EEPAJBBCGJK;
		}
		return this.OpCustom(254, dictionary, true);
	}

	// Token: 0x0600ADA0 RID: 44448 RVA: 0x00400EF4 File Offset: 0x003FF0F4
	public virtual bool OpFindFriends(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return this.OpCustom(222, dictionary, true);
	}

	// Token: 0x0600ADA1 RID: 44449 RVA: 0x00400F2B File Offset: 0x003FF12B
	public virtual bool OpLeaveLobby()
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "OpLeaveLobby()");
		}
		return this.OpCustom(228, null, true);
	}

	// Token: 0x0600ADA2 RID: 44450 RVA: 0x00400F58 File Offset: 0x003FF158
	public virtual bool PEBMBNGKOBH(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= (DebugLevel)7)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "checkpoint");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[(byte)-30] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[(byte)-28] = 1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[(byte)-81] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[(byte)-127] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[185] = 1;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[18] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[(byte)-95] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[199] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.PJMBJJMOILI(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom((byte)-109, dictionary, true);
	}

	// Token: 0x0600ADA3 RID: 44451 RVA: 0x004010B8 File Offset: 0x003FF2B8
	public virtual bool LKLAJKINLFG(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		this.EJELAMOKKKA.Clear();
		this.EJELAMOKKKA[188] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			this.EJELAMOKKKA[47] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != EventCaching.DoNotCache)
			{
				this.EJELAMOKKKA[(byte)-200] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != ReceiverGroup.Others)
			{
				this.EJELAMOKKKA[(byte)-50] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				this.EJELAMOKKKA[(byte)-80] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				this.EJELAMOKKKA[(byte)-126] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				this.EJELAMOKKKA[(byte)-103] = false;
			}
		}
		return this.OpCustom((byte)-149, this.EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	// Token: 0x0600ADA4 RID: 44452 RVA: 0x004011F0 File Offset: 0x003FF3F0
	public virtual bool MPKLAJGIHGP(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[(byte)-111] = PPNEJGFIAJP;
		return this.OpCustom((byte)-184, dictionary, false, 1, false);
	}

	// Token: 0x0600ADA5 RID: 44453 RVA: 0x00401220 File Offset: 0x003FF420
	public virtual bool BBIMCKFDFHG(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.WARNING)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "Adding player twice: ");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[(byte)-88] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[127] = 0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[147] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[199] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[(byte)-146] = 3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[(byte)-72] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[59] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[103] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom((byte)-87, dictionary, true);
	}

	// Token: 0x0600ADA6 RID: 44454 RVA: 0x00401380 File Offset: 0x003FF580
	protected void MGCPDDMDAIO(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.IILDKFGHOHK(hashtable, null, true);
	}

	// Token: 0x0600ADA7 RID: 44455 RVA: 0x004013AC File Offset: 0x003FF5AC
	protected internal bool IFBHCMGLLIM(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "CameraFilterPack/Blend2Camera_LighterColor");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if (this.DebugOut >= DebugLevel.ERROR)
			{
				base.Listener.DebugReturn((DebugLevel)7, "_TimeX");
			}
			return false;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add((byte)-187, FPBCPOGCCBD);
		dictionary.Add((byte)-171, KHACEEGCPEP);
		dictionary.Add(187, false);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add((byte)-185, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[(byte)-131] = false;
		}
		return this.OpCustom((byte)-183, dictionary, true, 0, true);
	}

	// Token: 0x0600ADA8 RID: 44456 RVA: 0x0040147C File Offset: 0x003FF67C
	public virtual bool DOFHCJGBGAD(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn((DebugLevel)6, "76561198041679481");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= (DebugLevel)6)
			{
				base.Listener.DebugReturn((DebugLevel)7, " Path: ");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != (LobbyType)1)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn((DebugLevel)6, "_CurveParams");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[46] = PKPEDDGHALP.Name;
		dictionary[28] = (byte)PKPEDDGHALP.Type;
		dictionary[(byte)-107] = INIFMIHFOGD;
		return this.OpCustom((byte)-49, dictionary, true);
	}

	// Token: 0x0600ADA9 RID: 44457 RVA: 0x0040153C File Offset: 0x003FF73C
	public virtual bool BJDOBCFLMAC(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn((DebugLevel)6, "mapselector.filter.officialsortmode");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[165] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[11] = 1;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[165] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[(byte)-145] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[98] = 4;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[52] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 1)
			{
				dictionary[105] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-92] = true;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom((byte)-167, dictionary, true);
	}

	// Token: 0x0600ADAA RID: 44458 RVA: 0x0040169C File Offset: 0x003FF89C
	public virtual bool MNJCIJOJAEM(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "rarity");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[119] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[139] = BBACCNINICP;
		}
		return this.OpCustom((byte)-145, dictionary, true, 1);
	}

	// Token: 0x0600ADAB RID: 44459 RVA: 0x00401700 File Offset: 0x003FF900
	public virtual bool HGLDGECBKBO(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 0)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return this.OpCustom((byte)-11, dictionary, false);
	}

	// Token: 0x0600ADAC RID: 44460 RVA: 0x00401738 File Offset: 0x003FF938
	public virtual bool AOIDAOKBANL(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= DebugLevel.WARNING)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "_TimeX");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[130] = GPDFHODMOIJ.Token;
			return this.OpCustom((byte)-161, dictionary, true, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)105 && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("_TimeX" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[(byte)-118] = (byte)AMKMACFDKEC;
		dictionary[(byte)-30] = (byte)NLNNMECNKEL;
		dictionary[(byte)-91] = GKMFHELOOOH;
		dictionary[(byte)-60] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[26] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[156] = GPDFHODMOIJ.NEPEFCOOEGO();
			}
			if (GPDFHODMOIJ.NKIEPEALJIB() != (CustomAuthenticationType)124)
			{
				dictionary[186] = (byte)GPDFHODMOIJ.NKIEPEALJIB();
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[(byte)-79] = GPDFHODMOIJ.DGINDFBNNDO();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[131] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[(byte)-167] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return this.OpCustom(145, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600ADAD RID: 44461 RVA: 0x004018F0 File Offset: 0x003FFAF0
	public virtual bool CBGKMKKPHOA(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn((DebugLevel)7, "Item invalid. Make sure your mod contains at leats one file.");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[102] = GPDFHODMOIJ.PPFIBJOHICJ();
			return this.OpCustom(149, dictionary, true, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)67 && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("GroupNameText" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Udp;
		}
		dictionary[(byte)-21] = (byte)AMKMACFDKEC;
		dictionary[172] = (byte)NLNNMECNKEL;
		dictionary[(byte)-169] = GKMFHELOOOH;
		dictionary[71] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-89] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[136] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)152)
			{
				dictionary[62] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[178] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[(byte)-124] = GPDFHODMOIJ.AuthGetParameters;
					}
					if (GPDFHODMOIJ.MLKCIABICJB() != null)
					{
						dictionary[(byte)-58] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return this.OpCustom((byte)-83, dictionary, true, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600ADAE RID: 44462 RVA: 0x00401AA8 File Offset: 0x003FFCA8
	protected void KCECKNONGIP(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.APMINOMEBPE(hashtable, null, false);
	}

	// Token: 0x0600ADAF RID: 44463 RVA: 0x00401AD2 File Offset: 0x003FFCD2
	public virtual bool NHOJKCKGGIH()
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn((DebugLevel)4, "#onrankchangeuptext");
		}
		return this.OpCustom((byte)-33, null, true);
	}

	// Token: 0x0600ADB0 RID: 44464 RVA: 0x00401B00 File Offset: 0x003FFD00
	public virtual bool OOECDGHNPEF(string[] MIMEHFLKIIG)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (MIMEHFLKIIG != null && MIMEHFLKIIG.Length > 1)
		{
			dictionary[1] = MIMEHFLKIIG;
		}
		return this.OpCustom((byte)-168, dictionary, false);
	}

	// Token: 0x0600ADB1 RID: 44465 RVA: 0x00401B38 File Offset: 0x003FFD38
	public virtual bool DPHMJJOHGCG(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_MatrixSize");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.BEDADDBKMLN())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[(byte)-131] = PKPEDDGHALP.Name;
			dictionary[177] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom((byte)-86, dictionary, true);
	}

	// Token: 0x0600ADB2 RID: 44466 RVA: 0x00401BAF File Offset: 0x003FFDAF
	public OHGAIJCPAJB(ConnectionProtocol MBOEJGPGFJB) : base(MBOEJGPGFJB)
	{
	}

	// Token: 0x0600ADB3 RID: 44467 RVA: 0x00401BC4 File Offset: 0x003FFDC4
	public virtual bool JIPNEAJNHEH(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "CameraFilterPack_Atmosphere_Rain_FX");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[(byte)-150] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.Lobby != null && !string.IsNullOrEmpty(HBJBKOPJDKJ.Lobby.Name))
		{
			dictionary[140] = HBJBKOPJDKJ.Lobby.Name;
			dictionary[(byte)-103] = (byte)HBJBKOPJDKJ.Lobby.Type;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 1)
		{
			dictionary[(byte)-43] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[(byte)-169] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[(byte)-5] = false;
			}
			this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
		}
		return this.OpCustom((byte)-112, dictionary, true);
	}

	// Token: 0x0600ADB4 RID: 44468 RVA: 0x00401CF3 File Offset: 0x003FFEF3
	public bool ODOJDLNLBEA(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return this.BHDGFLNLJCH(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, false);
	}

	// Token: 0x0600ADB5 RID: 44469 RVA: 0x00401D04 File Offset: 0x003FFF04
	public virtual bool OJKDKHPLIGO(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if (this.DebugOut >= (DebugLevel)8)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "win");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[2] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 1)
		{
			dictionary[56] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != MatchmakingMode.FillRoom)
		{
			dictionary[107] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[39] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[(byte)-195] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[(byte)-74] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[(byte)-94] = IFIMMPPLLHI.ExpectedUsers;
		}
		return this.OpCustom((byte)-36, dictionary, false);
	}

	// Token: 0x0600ADB6 RID: 44470 RVA: 0x003FF754 File Offset: 0x003FD954
	internal bool LEBELEEEIDO()
	{
		return base.UsedProtocol == ConnectionProtocol.Tcp;
	}

	// Token: 0x0600ADB7 RID: 44471 RVA: 0x00401E4F File Offset: 0x0040004F
	public virtual bool FKFDEKALFIN()
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "#random #rare #item");
		}
		return this.OpCustom((byte)-20, null, false);
	}

	// Token: 0x0600ADB8 RID: 44472 RVA: 0x00401E7C File Offset: 0x0040007C
	protected void NFMDPHKFHDL(byte OEOCEFAKLJD, object DPNHODJHGJL)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[OEOCEFAKLJD] = DPNHODJHGJL;
		this.OABLOBEGOPJ(hashtable, null, true);
	}

	// Token: 0x0600ADB9 RID: 44473 RVA: 0x00401EA8 File Offset: 0x004000A8
	public virtual bool OpChangeGroups(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "OpChangeGroups()");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[239] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[238] = BBACCNINICP;
		}
		return this.OpCustom(248, dictionary, true, 0);
	}

	// Token: 0x0600ADBA RID: 44474 RVA: 0x00401F0C File Offset: 0x0040010C
	public virtual bool KJGBJHIEKDC(byte[] GOIGIOGBCMF, byte[] BBACCNINICP)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "offsets");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GOIGIOGBCMF != null)
		{
			dictionary[60] = GOIGIOGBCMF;
		}
		if (BBACCNINICP != null)
		{
			dictionary[(byte)-107] = BBACCNINICP;
		}
		return this.OpCustom(38, dictionary, false, 1);
	}

	// Token: 0x0600ADBB RID: 44475 RVA: 0x00401F70 File Offset: 0x00400170
	public virtual bool IEBPDKACDBD(TypedLobby PKPEDDGHALP = null)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn((DebugLevel)8, "CameraFilterPack/Drawing_Manga_Flash");
		}
		Dictionary<byte, object> dictionary = null;
		if (PKPEDDGHALP != null && !PKPEDDGHALP.NAKOCKGALKH())
		{
			dictionary = new Dictionary<byte, object>();
			dictionary[70] = PKPEDDGHALP.Name;
			dictionary[39] = (byte)PKPEDDGHALP.Type;
		}
		return this.OpCustom(73, dictionary, true);
	}

	// Token: 0x0600ADBC RID: 44476 RVA: 0x00401FE8 File Offset: 0x004001E8
	public virtual bool DBOPFGEEBMH(string PPNEJGFIAJP)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[100] = PPNEJGFIAJP;
		return this.OpCustom(168, dictionary, true, 1, false);
	}

	// Token: 0x0600ADBD RID: 44477 RVA: 0x00402016 File Offset: 0x00400216
	internal bool MGBHJHHIMJF()
	{
		return base.UsedProtocol == (ConnectionProtocol)2;
	}

	// Token: 0x0600ADBE RID: 44478 RVA: 0x00402021 File Offset: 0x00400221
	public bool HDPOINGMPEE(int KHACEEGCPEP, Hashtable FPBCPOGCCBD)
	{
		return this.JBBEGBKFAMH(KHACEEGCPEP, FPBCPOGCCBD.StripToStringKeys(), null, false);
	}

	// Token: 0x0600ADBF RID: 44479 RVA: 0x00402034 File Offset: 0x00400234
	protected internal bool OABLOBEGOPJ(Hashtable MJJMNIDHDEC, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.ERROR)
		{
			base.Listener.DebugReturn((DebugLevel)4, "#onfirstranktext");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add((byte)-49, MJJMNIDHDEC);
		dictionary.Add(141, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add((byte)-113, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[131] = true;
		}
		return this.OpCustom((byte)-159, dictionary, false, 0, false);
	}

	// Token: 0x0600ADC0 RID: 44480 RVA: 0x004020C4 File Offset: 0x004002C4
	public virtual bool EMCJJFPNKCK(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		this.EJELAMOKKKA.Clear();
		this.EJELAMOKKKA[2] = IMCBEMICJFC;
		if (PEIFAPIIKNJ != null)
		{
			this.EJELAMOKKKA[(byte)-188] = PEIFAPIIKNJ;
		}
		if (BPLHAPBMGGC == null)
		{
			BPLHAPBMGGC = RaiseEventOptions.Default;
		}
		else
		{
			if (BPLHAPBMGGC.CachingOption != EventCaching.DoNotCache)
			{
				this.EJELAMOKKKA[(byte)-36] = (byte)BPLHAPBMGGC.CachingOption;
			}
			if (BPLHAPBMGGC.Receivers != ReceiverGroup.Others)
			{
				this.EJELAMOKKKA[(byte)-86] = (byte)BPLHAPBMGGC.Receivers;
			}
			if (BPLHAPBMGGC.InterestGroup != 0)
			{
				this.EJELAMOKKKA[(byte)-112] = BPLHAPBMGGC.InterestGroup;
			}
			if (BPLHAPBMGGC.TargetActors != null)
			{
				this.EJELAMOKKKA[(byte)-124] = BPLHAPBMGGC.TargetActors;
			}
			if (BPLHAPBMGGC.ForwardToWebhook)
			{
				this.EJELAMOKKKA[169] = true;
			}
		}
		return this.OpCustom((byte)-23, this.EJELAMOKKKA, ANMGHMBBMAO, BPLHAPBMGGC.SequenceChannel, BPLHAPBMGGC.Encrypt);
	}

	// Token: 0x0600ADC1 RID: 44481 RVA: 0x004021FC File Offset: 0x004003FC
	protected internal bool BHDGFLNLJCH(int KHACEEGCPEP, Hashtable FPBCPOGCCBD, Hashtable KCJIKJDCOAL = null, bool CDBHGINNCOF = false)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn((DebugLevel)6, "Floating point textures aren't supported on this device ({0})");
		}
		if (KHACEEGCPEP <= 1 || FPBCPOGCCBD == null)
		{
			if (this.DebugOut >= (DebugLevel)7)
			{
				base.Listener.DebugReturn((DebugLevel)4, "_ColorBuffer");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(127, FPBCPOGCCBD);
		dictionary.Add(95, KHACEEGCPEP);
		dictionary.Add(30, true);
		if (KCJIKJDCOAL != null && KCJIKJDCOAL.Count != 0)
		{
			dictionary.Add((byte)-14, KCJIKJDCOAL);
		}
		if (CDBHGINNCOF)
		{
			dictionary[196] = true;
		}
		return this.OpCustom(30, dictionary, false, 0, true);
	}

	// Token: 0x0600ADC2 RID: 44482 RVA: 0x004022CC File Offset: 0x004004CC
	public virtual bool MKJDEBIJGFK(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= DebugLevel.INFO)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "Stream did not contain properly formatted byte array");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= (DebugLevel)7)
			{
				base.Listener.DebugReturn((DebugLevel)6, "_LutTex");
			}
			return true;
		}
		if (PKPEDDGHALP.Type != LobbyType.AsyncRandomLobby)
		{
			if (this.DebugOut >= DebugLevel.WARNING)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "Clears the console and prints the logs in the specified range");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[(byte)-146] = PKPEDDGHALP.Name;
		dictionary[(byte)-123] = (byte)PKPEDDGHALP.Type;
		dictionary[21] = INIFMIHFOGD;
		return this.OpCustom((byte)-148, dictionary, false);
	}

	// Token: 0x0600ADC3 RID: 44483 RVA: 0x0040238C File Offset: 0x0040058C
	public virtual bool EIEGEHCICNP(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		if (this.DebugOut >= DebugLevel.WARNING)
		{
			base.Listener.DebugReturn((DebugLevel)8, "14");
		}
		Hashtable hashtable = new Hashtable();
		hashtable.MergeStringKeys(IFIMMPPLLHI.ExpectedCustomRoomProperties);
		if (IFIMMPPLLHI.ExpectedMaxPlayers > 1)
		{
			hashtable[(byte)-195] = IFIMMPPLLHI.ExpectedMaxPlayers;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (hashtable.Count > 0)
		{
			dictionary[35] = hashtable;
		}
		if (IFIMMPPLLHI.MatchingType != MatchmakingMode.FillRoom)
		{
			dictionary[114] = (byte)IFIMMPPLLHI.MatchingType;
		}
		if (IFIMMPPLLHI.TypedLobby != null && !string.IsNullOrEmpty(IFIMMPPLLHI.TypedLobby.Name))
		{
			dictionary[(byte)-132] = IFIMMPPLLHI.TypedLobby.Name;
			dictionary[107] = (byte)IFIMMPPLLHI.TypedLobby.Type;
		}
		if (!string.IsNullOrEmpty(IFIMMPPLLHI.SqlLobbyFilter))
		{
			dictionary[91] = IFIMMPPLLHI.SqlLobbyFilter;
		}
		if (IFIMMPPLLHI.ExpectedUsers != null && IFIMMPPLLHI.ExpectedUsers.Length > 0)
		{
			dictionary[(byte)-22] = IFIMMPPLLHI.ExpectedUsers;
		}
		return this.OpCustom(114, dictionary, true);
	}

	// Token: 0x0600ADC4 RID: 44484 RVA: 0x004024D8 File Offset: 0x004006D8
	public virtual bool KNNOIBMABCN(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= DebugLevel.OFF)
		{
			base.Listener.DebugReturn((DebugLevel)6, "_ScreenResolution");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.Token != null)
		{
			dictionary[58] = GPDFHODMOIJ.PPFIBJOHICJ();
			return this.OpCustom(180, dictionary, false, 0, false);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-64) && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("Chat" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[158] = (byte)AMKMACFDKEC;
		dictionary[(byte)-19] = (byte)NLNNMECNKEL;
		dictionary[10] = GKMFHELOOOH;
		dictionary[(byte)-59] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[45] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.UserId))
			{
				dictionary[(byte)-183] = GPDFHODMOIJ.UserId;
			}
			if ((int)GPDFHODMOIJ.AuthType != -90)
			{
				dictionary[(byte)-90] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.DGINDFBNNDO()))
				{
					dictionary[20] = GPDFHODMOIJ.Token;
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.OMCPFLLPIPM()))
					{
						dictionary[166] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[(byte)-199] = GPDFHODMOIJ.MLKCIABICJB();
					}
				}
			}
		}
		return this.OpCustom(24, dictionary, true, 1, base.IsEncryptionAvailable);
	}

	// Token: 0x0600ADC5 RID: 44485 RVA: 0x00402690 File Offset: 0x00400890
	public virtual bool PNKFPJJPELO(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.WARNING, "_Amount");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (!string.IsNullOrEmpty(HBJBKOPJDKJ.RoomName))
		{
			dictionary[39] = HBJBKOPJDKJ.RoomName;
		}
		if (HBJBKOPJDKJ.CreateIfNotExists)
		{
			dictionary[(byte)-67] = 0;
			if (HBJBKOPJDKJ.Lobby != null)
			{
				dictionary[(byte)-88] = HBJBKOPJDKJ.Lobby.Name;
				dictionary[(byte)-13] = (byte)HBJBKOPJDKJ.Lobby.Type;
			}
		}
		if (HBJBKOPJDKJ.RejoinOnly)
		{
			dictionary[59] = 3;
		}
		if (HBJBKOPJDKJ.ExpectedUsers != null && HBJBKOPJDKJ.ExpectedUsers.Length > 0)
		{
			dictionary[(byte)-10] = HBJBKOPJDKJ.ExpectedUsers;
		}
		if (HBJBKOPJDKJ.OnGameServer)
		{
			if (HBJBKOPJDKJ.PlayerProperties != null && HBJBKOPJDKJ.PlayerProperties.Count > 0)
			{
				dictionary[71] = HBJBKOPJDKJ.PlayerProperties;
				dictionary[175] = false;
			}
			if (HBJBKOPJDKJ.CreateIfNotExists)
			{
				this.KFMBAGPOOPO(dictionary, HBJBKOPJDKJ.RoomOptions);
			}
		}
		return this.OpCustom(180, dictionary, false);
	}

	// Token: 0x0600ADC6 RID: 44486 RVA: 0x004027F0 File Offset: 0x004009F0
	public virtual bool OLOMFHLPHDH(TypedLobby PKPEDDGHALP, string INIFMIHFOGD)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.ALL, "_Heigh");
		}
		if (PKPEDDGHALP == null)
		{
			if (this.DebugOut >= (DebugLevel)8)
			{
				base.Listener.DebugReturn(DebugLevel.ERROR, "colorD");
			}
			return false;
		}
		if (PKPEDDGHALP.Type != LobbyType.Default)
		{
			if (this.DebugOut >= DebugLevel.OFF)
			{
				base.Listener.DebugReturn((DebugLevel)6, "SpawnObj");
			}
			return true;
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[178] = PKPEDDGHALP.Name;
		dictionary[(byte)-45] = (byte)PKPEDDGHALP.Type;
		dictionary[(byte)-179] = INIFMIHFOGD;
		return this.OpCustom(7, dictionary, false);
	}

	// Token: 0x0600ADC7 RID: 44487 RVA: 0x004028B0 File Offset: 0x00400AB0
	public virtual bool MDEGPIGGGEE(string PPNEJGFIAJP, string GKMFHELOOOH, AuthenticationValues GPDFHODMOIJ, string NINPMKJNNDM, EncryptionMode NLNNMECNKEL, ConnectionProtocol AMKMACFDKEC)
	{
		if (this.DebugOut >= (DebugLevel)6)
		{
			base.Listener.DebugReturn(DebugLevel.ERROR, "_Value2");
		}
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		if (GPDFHODMOIJ != null && GPDFHODMOIJ.DGINDFBNNDO() != null)
		{
			dictionary[16] = GPDFHODMOIJ.DGINDFBNNDO();
			return this.OpCustom(76, dictionary, false, 0, true);
		}
		if (NLNNMECNKEL == (EncryptionMode)(-125) && AMKMACFDKEC != ConnectionProtocol.Udp)
		{
			Debug.LogWarning("_TimeX" + PhotonNetwork.PhotonServerSettings.Protocol);
			PhotonNetwork.PhotonServerSettings.Protocol = ConnectionProtocol.Udp;
			AMKMACFDKEC = ConnectionProtocol.Tcp;
		}
		dictionary[165] = (byte)AMKMACFDKEC;
		dictionary[(byte)-101] = (byte)NLNNMECNKEL;
		dictionary[170] = GKMFHELOOOH;
		dictionary[166] = PPNEJGFIAJP;
		if (!string.IsNullOrEmpty(NINPMKJNNDM))
		{
			dictionary[(byte)-36] = NINPMKJNNDM;
		}
		if (GPDFHODMOIJ != null)
		{
			if (!string.IsNullOrEmpty(GPDFHODMOIJ.NEPEFCOOEGO()))
			{
				dictionary[148] = GPDFHODMOIJ.UserId;
			}
			if (GPDFHODMOIJ.AuthType != (CustomAuthenticationType)192)
			{
				dictionary[128] = (byte)GPDFHODMOIJ.AuthType;
				if (!string.IsNullOrEmpty(GPDFHODMOIJ.Token))
				{
					dictionary[(byte)-90] = GPDFHODMOIJ.PPFIBJOHICJ();
				}
				else
				{
					if (!string.IsNullOrEmpty(GPDFHODMOIJ.AuthGetParameters))
					{
						dictionary[(byte)-189] = GPDFHODMOIJ.OMCPFLLPIPM();
					}
					if (GPDFHODMOIJ.LPMFOIPADGG() != null)
					{
						dictionary[170] = GPDFHODMOIJ.AuthPostData;
					}
				}
			}
		}
		return this.OpCustom(163, dictionary, false, 0, base.IsEncryptionAvailable);
	}

	// Token: 0x0600ADC8 RID: 44488 RVA: 0x00402A68 File Offset: 0x00400C68
	public virtual bool CJKBKAJFFJA()
	{
		if (this.DebugOut >= (DebugLevel)8)
		{
			base.Listener.DebugReturn(DebugLevel.OFF, "_CurTex");
		}
		return this.OpCustom(158, null, false);
	}

	// Token: 0x0600ADC9 RID: 44489 RVA: 0x00402A94 File Offset: 0x00400C94
	public virtual bool CJJOICDBDNJ()
	{
		if (this.DebugOut >= (DebugLevel)4)
		{
			base.Listener.DebugReturn((DebugLevel)7, "_ScreenResolution");
		}
		return this.OpCustom((byte)-61, null, true);
	}

	// Token: 0x0600ADCA RID: 44490 RVA: 0x00402AC0 File Offset: 0x00400CC0
	public virtual bool NGMNPIIMODA(bool GNAFHNLBPHP)
	{
		if (this.DebugOut >= DebugLevel.ALL)
		{
			base.Listener.DebugReturn(DebugLevel.INFO, "menu.enableselectormusic");
		}
		this.EJELAMOKKKA.Clear();
		if (GNAFHNLBPHP)
		{
			this.EJELAMOKKKA[1] = GNAFHNLBPHP;
		}
		return this.EJELAMOKKKA.Count == 0 || this.OpCustom((byte)-14, this.EJELAMOKKKA, true);
	}

	// Token: 0x04001371 RID: 4977
	private readonly Dictionary<byte, object> EJELAMOKKKA = new Dictionary<byte, object>();

	// Token: 0x020002E7 RID: 743
	private enum DBMPJAAINPM
	{
		// Token: 0x04001373 RID: 4979
		CheckUserOnJoin = 1,
		// Token: 0x04001374 RID: 4980
		DeleteCacheOnLeave,
		// Token: 0x04001375 RID: 4981
		SuppressRoomEvents = 4,
		// Token: 0x04001376 RID: 4982
		PublishUserId = 8,
		// Token: 0x04001377 RID: 4983
		DeleteNullProps = 16,
		// Token: 0x04001378 RID: 4984
		BroadcastPropsChangeToAll = 32
	}
}
