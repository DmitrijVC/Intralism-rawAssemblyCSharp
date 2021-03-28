using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200041E RID: 1054
public class GetProcessesJob : ThreadedJob
{
	// Token: 0x0600F19F RID: 61855 RVA: 0x00540D94 File Offset: 0x0053EF94
	protected virtual void ECMEIIOGOLC()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "GameScene",
				Arguments = "Up",
				Verb = "BitsData",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("editor.");
		}
	}

	// Token: 0x0600F1A0 RID: 61856 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void CFPEGNHBKLK()
	{
	}

	// Token: 0x0600F1A1 RID: 61857 RVA: 0x00540E74 File Offset: 0x0053F074
	protected virtual void DNKDEPBOLKD()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_SizeY",
				Arguments = "_ScreenResolution",
				Verb = "Objects in List: ",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("CameraFilterPack/Sharpen_Sharpen");
		}
	}

	// Token: 0x0600F1A2 RID: 61858 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void OAKBHENIEDD()
	{
	}

	// Token: 0x0600F1A3 RID: 61859 RVA: 0x00540F54 File Offset: 0x0053F154
	protected virtual void PDDDPNPFCFP()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_Amount",
				Arguments = "SpectateButton",
				Verb = " base map(s)",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("settings.enablerankingnotifications");
		}
	}

	// Token: 0x0600F1A4 RID: 61860 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void FNCACIILJFI()
	{
	}

	// Token: 0x0600F1A5 RID: 61861 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void EJNPMGJDGLJ()
	{
	}

	// Token: 0x0600F1A6 RID: 61862 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void NHJPFGGNEML()
	{
	}

	// Token: 0x0600F1A7 RID: 61863 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void EDCFDDENFFG()
	{
	}

	// Token: 0x0600F1A8 RID: 61864 RVA: 0x00541034 File Offset: 0x0053F234
	protected virtual void NFIHFJLOFBJ()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = " ",
				Arguments = "_Green_R",
				Verb = "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_DiffuseColor");
		}
	}

	// Token: 0x0600F1A9 RID: 61865 RVA: 0x00541114 File Offset: 0x0053F314
	protected virtual void DMBLJKLDDEA()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "] to be droppable",
				Arguments = "OK",
				Verb = "Keypad ",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("finished");
		}
	}

	// Token: 0x0600F1AA RID: 61866 RVA: 0x005411F4 File Offset: 0x0053F3F4
	protected virtual void GLBPEENJFIF()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_ScreenResolution",
				Arguments = "CameraFilterPack/Blend2Camera_Saturation",
				Verb = "Left",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("CameraFilterPack/Oculus_NightVision1");
		}
	}

	// Token: 0x0600F1AB RID: 61867 RVA: 0x005412D4 File Offset: 0x0053F4D4
	protected virtual void HFEPBABPKJF()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "Gameplay/satellite",
				Arguments = "_Value1",
				Verb = "_Near",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("DPADVER");
		}
	}

	// Token: 0x0600F1AC RID: 61868 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void FPBNBIOODID()
	{
	}

	// Token: 0x0600F1AD RID: 61869 RVA: 0x005413B4 File Offset: 0x0053F5B4
	protected virtual void HAMNIIONCAH()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "editor.",
				Arguments = "player.rgb",
				Verb = "_ToPrevViewProjCombined",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_ScreenResolution");
		}
	}

	// Token: 0x0600F1AE RID: 61870 RVA: 0x0002523B File Offset: 0x0002343B
	protected override void MNOCACNOIPB()
	{
	}

	// Token: 0x0600F1AF RID: 61871 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void PJKAHCHLPDF()
	{
	}

	// Token: 0x0600F1B0 RID: 61872 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void DFJHEJCCJGI()
	{
	}

	// Token: 0x0600F1B1 RID: 61873 RVA: 0x00541494 File Offset: 0x0053F694
	protected override void CGMJODOBINA()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "workshop.",
				Arguments = "ns",
				Verb = "[LevelEditorScene] Map submitted!",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("player.deleted");
		}
	}

	// Token: 0x0600F1B2 RID: 61874 RVA: 0x0002523B File Offset: 0x0002343B
	protected override void BOACMLIHMGP()
	{
	}

	// Token: 0x0600F1B3 RID: 61875 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void MJCHGGIJPOA()
	{
	}

	// Token: 0x0600F1B4 RID: 61876 RVA: 0x00541574 File Offset: 0x0053F774
	protected virtual void BOMDNIJDLNI()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "path",
				Arguments = "Object ID. Case-Sensitive",
				Verb = "_MainTex2",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("<scene_name> or <id>");
		}
	}

	// Token: 0x0600F1B5 RID: 61877 RVA: 0x00541654 File Offset: 0x0053F854
	protected virtual void FEFJPHMFONF()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "CameraFilterPack/Gradients_Hue",
				Arguments = "settings.selectormapsperpage",
				Verb = "GlassColor",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("CameraFilterPack/TV_WideScreenHV");
		}
	}

	// Token: 0x0600F1B6 RID: 61878 RVA: 0x00541734 File Offset: 0x0053F934
	protected virtual void MIBAKHAGDOP()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_Parameter",
				Arguments = "CameraFilterPack/EyesVision_2",
				Verb = "SfxVolumeSlider",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("note.1");
		}
	}

	// Token: 0x0600F1B7 RID: 61879 RVA: 0x00541814 File Offset: 0x0053FA14
	protected virtual void DINCOHFJLGB()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "Tab1Content",
				Arguments = "Hex value #RRGGBB",
				Verb = "UseScanLineSize",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("maps.");
		}
	}

	// Token: 0x0600F1B8 RID: 61880 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void PLCDOOJMBHN()
	{
	}

	// Token: 0x0600F1B9 RID: 61881 RVA: 0x005418F4 File Offset: 0x0053FAF4
	protected virtual void ACEJNNKPPGI()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_Value3",
				Arguments = "_TimeX",
				Verb = "_RampOffset",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("turn");
		}
	}

	// Token: 0x0600F1BA RID: 61882 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void HCIEKDOFLJG()
	{
	}

	// Token: 0x0600F1BB RID: 61883 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void HDGHJPAJIEP()
	{
	}

	// Token: 0x0600F1BC RID: 61884 RVA: 0x005419D4 File Offset: 0x0053FBD4
	protected virtual void FMJPOOIHADM()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "In Maps Editor",
				Arguments = "Encryption wasn't established: ",
				Verb = " is muted",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("pointBuffer");
		}
	}

	// Token: 0x0600F1BD RID: 61885 RVA: 0x00541AB4 File Offset: 0x0053FCB4
	protected virtual void BBMFOMHPGHH()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "CameraFilterPack_TV_BrokenGlass1",
				Arguments = "PlayMapGoal",
				Verb = "SetSunColors",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_VignettingDirt");
		}
	}

	// Token: 0x0600F1BE RID: 61886 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void MBPJCAPNFCC()
	{
	}

	// Token: 0x0600F1BF RID: 61887 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void KENFGMGMKJI()
	{
	}

	// Token: 0x0600F1C0 RID: 61888 RVA: 0x00541B94 File Offset: 0x0053FD94
	protected virtual void APCDEEPLJKO()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_Value2",
				Arguments = "CheckpointsScoreText",
				Verb = ". ActorNr: ",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_NoiseTex");
		}
	}

	// Token: 0x0600F1C1 RID: 61889 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void POFNAKKEPIJ()
	{
	}

	// Token: 0x0600F1C2 RID: 61890 RVA: 0x00541C74 File Offset: 0x0053FE74
	protected virtual void EOOJHKFELKM()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "_Value2",
				Arguments = "_VelTex",
				Verb = "_Distortion",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_Value3");
		}
	}

	// Token: 0x0600F1C3 RID: 61891 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void KFDLFHNPAHJ()
	{
	}

	// Token: 0x0600F1C4 RID: 61892 RVA: 0x00541D54 File Offset: 0x0053FF54
	protected override void EAEAHCKIDCP()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "LastHighScoreText",
				Arguments = "_Near",
				Verb = "CameraFilterPack/Blend2Camera_Screen",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_Value");
		}
	}

	// Token: 0x0600F1C5 RID: 61893 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void AENBIDPBKHL()
	{
	}

	// Token: 0x0600F1C6 RID: 61894 RVA: 0x00541E34 File Offset: 0x00540034
	protected virtual void LPALPMFBKGJ()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "checkpoint",
				Arguments = "/",
				Verb = "<start_index> <end_index>",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_Value");
		}
	}

	// Token: 0x0600F1C7 RID: 61895 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void NEIPAKEGJHH()
	{
	}

	// Token: 0x0600F1C8 RID: 61896 RVA: 0x00541F14 File Offset: 0x00540114
	protected virtual void BLHMPFCIAJC()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "setbool",
				Arguments = "SaveButton",
				Verb = "_Value",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_Green_G");
		}
	}

	// Token: 0x0600F1C9 RID: 61897 RVA: 0x00541FF4 File Offset: 0x005401F4
	protected override void GODPOOJFKEF()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "SUBMIT '{0}' FILES",
				Arguments = "ViewMenu",
				Verb = "icon",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("OpenButton");
		}
	}

	// Token: 0x0600F1CA RID: 61898 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void JIMJIGDBGDD()
	{
	}

	// Token: 0x0600F1CB RID: 61899 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void POJFJEGCBAI()
	{
	}

	// Token: 0x0600F1CC RID: 61900 RVA: 0x005420D4 File Offset: 0x005402D4
	protected virtual void GIEKJDNBKMO()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "_Red_C",
				Arguments = "OxOD.lastPath",
				Verb = "CameraFilterPack/Blend2Camera_ColorBurn",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("Joystick");
		}
	}

	// Token: 0x0600F1CD RID: 61901 RVA: 0x005421B4 File Offset: 0x005403B4
	protected virtual void BMHFEIHGELF()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "Horizontal",
				Arguments = "https://twitch.tv/intralism",
				Verb = "_Value2",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_Red_C");
		}
	}

	// Token: 0x0600F1CE RID: 61902 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void ELMFKPOLGIP()
	{
	}

	// Token: 0x0600F1CF RID: 61903 RVA: 0x00542294 File Offset: 0x00540494
	protected virtual void GIDCKKBNMBM()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "maps.",
				Arguments = "offsets",
				Verb = "#ok",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_SceneFogMode");
		}
	}

	// Token: 0x0600F1D0 RID: 61904 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void NHABLACAJKN()
	{
	}

	// Token: 0x0600F1D1 RID: 61905 RVA: 0x00542374 File Offset: 0x00540574
	protected override void HNBCBALPKON()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "Ignored PU RPC, cause item is inactive. ",
				Arguments = "#yes",
				Verb = "_HalfResolution",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("[PlayerController] ");
		}
	}

	// Token: 0x0600F1D2 RID: 61906 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void POFIKBNAKFI()
	{
	}

	// Token: 0x0600F1D3 RID: 61907 RVA: 0x00542454 File Offset: 0x00540654
	protected virtual void GJDFLBJHLCI()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "menu.enableselectormusic",
				Arguments = "[UI] ",
				Verb = "Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("mapselector.filter.favoriteonly");
		}
	}

	// Token: 0x0600F1D4 RID: 61908 RVA: 0x00542534 File Offset: 0x00540734
	protected virtual void KIECFLDLDMB()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "_Sat",
				Arguments = "_Val",
				Verb = "Tab1Content",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_Value");
		}
	}

	// Token: 0x0600F1D5 RID: 61909 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void EGDBOOCKOKO()
	{
	}

	// Token: 0x0600F1D6 RID: 61910 RVA: 0x00542614 File Offset: 0x00540814
	protected virtual void HPLJIIGDDKG()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "CameraFilterPack/Blend2Camera_Multiply",
				Arguments = "EndlessLoopsScoreText",
				Verb = "SetLives",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("clear");
		}
	}

	// Token: 0x0600F1D7 RID: 61911 RVA: 0x005426F4 File Offset: 0x005408F4
	protected virtual void DNNGILMNLHN()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "IntraTime",
				Arguments = "help",
				Verb = "Joystick1Button1",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_dec.json");
		}
	}

	// Token: 0x0600F1D8 RID: 61912 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void JHDOPBNOHGD()
	{
	}

	// Token: 0x0600F1D9 RID: 61913 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void NNBOMFEHECG()
	{
	}

	// Token: 0x0600F1DA RID: 61914 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void IDHCIKEAODF()
	{
	}

	// Token: 0x0600F1DB RID: 61915 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void OLDLHPCAFEO()
	{
	}

	// Token: 0x0600F1DC RID: 61916 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void BPCFGDODIJH()
	{
	}

	// Token: 0x0600F1DD RID: 61917 RVA: 0x005427D4 File Offset: 0x005409D4
	protected virtual void LGCPLKEONJM()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "_Speed",
				Arguments = "_ScreenResolution",
				Verb = ".completed",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("position");
		}
	}

	// Token: 0x0600F1DE RID: 61918 RVA: 0x005428B4 File Offset: 0x00540AB4
	protected virtual void OFFANFJALMA()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_EmissionGain",
				Arguments = "#news",
				Verb = "_TimeX",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add(".png");
		}
	}

	// Token: 0x0600F1E0 RID: 61920 RVA: 0x0054299C File Offset: 0x00540B9C
	protected virtual void LLCOADBOHGA()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_Value2",
				Arguments = "_Offsets",
				Verb = "_Value7",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("settings.volume.editor");
		}
	}

	// Token: 0x0600F1E1 RID: 61921 RVA: 0x00542A7C File Offset: 0x00540C7C
	protected override void JLAPONBAOHB()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "_Value4",
				Arguments = "challenges",
				Verb = "_Value7",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_ScreenResolution");
		}
	}

	// Token: 0x0600F1E2 RID: 61922 RVA: 0x00542B5C File Offset: 0x00540D5C
	protected virtual void GFGAPJLFMGL()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "#news",
				Arguments = "curScn",
				Verb = "MenuScene",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_TimeX");
		}
	}

	// Token: 0x0600F1E3 RID: 61923 RVA: 0x00542C3C File Offset: 0x00540E3C
	protected override void JAFCCBIPELN()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "cmd.exe",
				Arguments = "/C tasklist",
				Verb = "runas",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("Error0");
		}
	}

	// Token: 0x0600F1E4 RID: 61924 RVA: 0x00542D1C File Offset: 0x00540F1C
	protected virtual void LFMLPCOONKN()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "/icon",
				Arguments = "ResourceFileSelector",
				Verb = "GLITCH",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("Object ID. Case-Sensitive");
		}
	}

	// Token: 0x0600F1E5 RID: 61925 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void GHPPKPKAPMG()
	{
	}

	// Token: 0x0600F1E6 RID: 61926 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void OANIGEHKJFE()
	{
	}

	// Token: 0x0600F1E7 RID: 61927 RVA: 0x0002523B File Offset: 0x0002343B
	protected override void BLFNOPKJDGC()
	{
	}

	// Token: 0x0600F1E8 RID: 61928 RVA: 0x00542DFC File Offset: 0x00540FFC
	protected virtual void MGKJJNFKBFO()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "Tab1Content",
				Arguments = "_Value2",
				Verb = "NetworkCanvas",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("SetSunSensitivity");
		}
	}

	// Token: 0x0600F1E9 RID: 61929 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void NNMMPCGIFHK()
	{
	}

	// Token: 0x0600F1EA RID: 61930 RVA: 0x00542EDC File Offset: 0x005410DC
	protected virtual void PILGEDLKNEM()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "Edited unlock conditions",
				Arguments = "_Value3",
				Verb = " By: ",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("RedoButton");
		}
	}

	// Token: 0x0600F1EB RID: 61931 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void INOAGLEGOIK()
	{
	}

	// Token: 0x0600F1EC RID: 61932 RVA: 0x00542FBC File Offset: 0x005411BC
	protected virtual void PLLAFFJPFGK()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "skin.hit_wrong",
				Arguments = "score:",
				Verb = "_FadeShield",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("GameVolumeSlider");
		}
	}

	// Token: 0x0600F1ED RID: 61933 RVA: 0x0054309C File Offset: 0x0054129C
	protected virtual void FGMMNICIPCH()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "Hidden/DepthOfField/BokehSplatting",
				Arguments = "move",
				Verb = "RanksButton",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add(" not exist");
		}
	}

	// Token: 0x0600F1EE RID: 61934 RVA: 0x0054317C File Offset: 0x0054137C
	protected virtual void LNMBIKNNKKG()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "1 Kb",
				Arguments = "_Intensity",
				Verb = "open",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("float,0");
		}
	}

	// Token: 0x0600F1EF RID: 61935 RVA: 0x0002523B File Offset: 0x0002343B
	protected override void IHCBHMKFDMK()
	{
	}

	// Token: 0x0600F1F0 RID: 61936 RVA: 0x0054325C File Offset: 0x0054145C
	protected virtual void CAPAEFDDBKA()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "[LevelEditorScene] Item creation successful! Published Item ID: ",
				Arguments = "CameraFilterPack/Oculus_NightVision3",
				Verb = "player.blackwhite",
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("[DiscordController] Shutdown");
		}
	}

	// Token: 0x0600F1F1 RID: 61937 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void CPJDOKECGFM()
	{
	}

	// Token: 0x0600F1F2 RID: 61938 RVA: 0x0054333C File Offset: 0x0054153C
	protected virtual void IMGOKKAJCDN()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_TimeX",
				Arguments = "Joystick1Button6",
				Verb = "Traffic Stats",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("EditMenu");
		}
	}

	// Token: 0x0600F1F3 RID: 61939 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void HOAJKHOOEJI()
	{
	}

	// Token: 0x0600F1F4 RID: 61940 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void POCACGNNLPH()
	{
	}

	// Token: 0x0600F1F5 RID: 61941 RVA: 0x0054341C File Offset: 0x0054161C
	protected virtual void CNMMINLAPIF()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = "error",
				Arguments = "_MainTex",
				Verb = "#",
				RedirectStandardOutput = false,
				RedirectStandardError = true,
				UseShellExecute = true,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_Blue_B");
		}
	}

	// Token: 0x0600F1F6 RID: 61942 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void PGDPJOJHNFH()
	{
	}

	// Token: 0x0600F1F7 RID: 61943 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void AOKHFOKHLFB()
	{
	}

	// Token: 0x0600F1F8 RID: 61944 RVA: 0x005434FC File Offset: 0x005416FC
	protected virtual void MNDCHDKHCNI()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "SetSatelliteRotationSpeed",
				Arguments = "OnAwakeRPC",
				Verb = "GlassAberration",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add(".lastCheckpoint.playerdistance");
		}
	}

	// Token: 0x0600F1F9 RID: 61945 RVA: 0x005435DC File Offset: 0x005417DC
	protected virtual void NNHFKEEDJML()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "_Distortion",
				Arguments = "null",
				Verb = "\n",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = true,
				CreateNoWindow = true
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("CameraFilterPack/Blend2Camera_VividLight");
		}
	}

	// Token: 0x0600F1FA RID: 61946 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void FIGEDBOOGFK()
	{
	}

	// Token: 0x0600F1FB RID: 61947 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void EDHDBELBMKO()
	{
	}

	// Token: 0x0600F1FC RID: 61948 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void EKDDMHLDHIL()
	{
	}

	// Token: 0x0600F1FD RID: 61949 RVA: 0x005436BC File Offset: 0x005418BC
	protected virtual void GCCKMJPJLOD()
	{
		this.activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Normal,
				FileName = " in SaveLoadMenu.prefabDictionary!",
				Arguments = "_Value4",
				Verb = "setint",
				RedirectStandardOutput = true,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = false
			};
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			this.activeProcesses.Add("_ScreenResolution");
		}
	}

	// Token: 0x04001AD3 RID: 6867
	public List<string> activeProcesses;
}
