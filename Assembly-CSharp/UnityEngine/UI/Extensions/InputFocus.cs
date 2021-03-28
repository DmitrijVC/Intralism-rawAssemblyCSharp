using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002B0 RID: 688
	[AddComponentMenu("UI/Extensions/InputFocus")]
	[RequireComponent(typeof(InputField))]
	public class InputFocus : MonoBehaviour
	{
		// Token: 0x0600A57C RID: 42364 RVA: 0x003DC948 File Offset: 0x003DAB48
		private void DDBOODLPCAM()
		{
			if (Input.GetKeyUp((KeyCode)18) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x003DC9A0 File Offset: 0x003DABA0
		public void BPFINAJGMAJ()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x003DC9F0 File Offset: 0x003DABF0
		public void KELNPAAHDAF(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)68))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x003DCA40 File Offset: 0x003DAC40
		public void MFFDDFJGFLO(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-53)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void AEDDNDHCLNN()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void AEMGPJDJGBJ()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x003DCA9C File Offset: 0x003DAC9C
		private void LDDKCCMHMIC()
		{
			if (Input.GetKeyUp(KeyCode.Greater) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x003DCAF4 File Offset: 0x003DACF4
		public void DELKCEAFKEJ()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x003DCB44 File Offset: 0x003DAD44
		private void JAAJECBCCFM()
		{
			if (Input.GetKeyUp((KeyCode)(-15)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x003DCB9C File Offset: 0x003DAD9C
		private void KCDOMIJBFLL()
		{
			if (Input.GetKeyUp(KeyCode.Comma) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x003DCBF4 File Offset: 0x003DADF4
		public void GFHEINNMILP(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-20)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x003DCC44 File Offset: 0x003DAE44
		public void FCCEPNDNJDD(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)7))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x003DCC94 File Offset: 0x003DAE94
		public void AJBIEJLMCHN()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A58A RID: 42378 RVA: 0x003DCCE4 File Offset: 0x003DAEE4
		public void DIBPLNLLHMK(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-85)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void JOPCCCCHNLI()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void JABNHMIHBHC()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x003DCD34 File Offset: 0x003DAF34
		private void ONKDMMJPEMN()
		{
			if (Input.GetKeyUp((KeyCode)(-56)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x003DCD8C File Offset: 0x003DAF8C
		public void GDPPIDIGHIP()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x003DCDDC File Offset: 0x003DAFDC
		public void KLLJKLBBGBN()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x003DCE2C File Offset: 0x003DB02C
		private void JDGFCEPDKAJ()
		{
			if (Input.GetKeyUp(KeyCode.Hash) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x003DCE84 File Offset: 0x003DB084
		public void buttonPressed()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void PKLOBJHKFEO()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x003DCED4 File Offset: 0x003DB0D4
		private void IBFJAOINHMK()
		{
			if (Input.GetKeyUp((KeyCode)67) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x003DCF2C File Offset: 0x003DB12C
		private void CFIAKIJAILI()
		{
			if (Input.GetKeyUp((KeyCode)(-109)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x003DCF84 File Offset: 0x003DB184
		public void JHALEOOJNEG(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)75))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x003DCFD4 File Offset: 0x003DB1D4
		public void GLPOHOHANBA()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x003DD024 File Offset: 0x003DB224
		private void OPCLBGHAPMG()
		{
			if (Input.GetKeyUp((KeyCode)(-121)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x003DD07C File Offset: 0x003DB27C
		public void LLNIOCENOEH()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A599 RID: 42393 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void FHGKIOOMMOH()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x003DD0CC File Offset: 0x003DB2CC
		private void GCHBGCGBMCK()
		{
			if (Input.GetKeyUp(KeyCode.X) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x003DD124 File Offset: 0x003DB324
		public void KDKIPEJLGGD(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-52)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x003DD174 File Offset: 0x003DB374
		public void BGOCPHHBONN()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x003DD1C4 File Offset: 0x003DB3C4
		public void NAHBIKEEBGJ()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void KNBJBNDGCIJ()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x003DD214 File Offset: 0x003DB414
		private void LEAHIBJDMBI()
		{
			if (Input.GetKeyUp((KeyCode)73) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x003DD26C File Offset: 0x003DB46C
		public void BALOECFPBAA()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x003DD2BC File Offset: 0x003DB4BC
		public void PFBOGHBJPKM()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x003DD30C File Offset: 0x003DB50C
		public void NDNHIJOOGLG()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x003DD35C File Offset: 0x003DB55C
		private void JBNPEHMDCMI()
		{
			if (Input.GetKeyUp((KeyCode)(-104)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void BMOFEBKGLFI()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x003DD3B4 File Offset: 0x003DB5B4
		private void AGMJDGHLBMN()
		{
			if (Input.GetKeyUp((KeyCode)(-7)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x003DD40C File Offset: 0x003DB60C
		public void HLPBHCPDCNO()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void ALNNIDLFILB()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x003DD45C File Offset: 0x003DB65C
		public void BLDDLOHCDEI(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-112)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x003DD4AC File Offset: 0x003DB6AC
		public void LHDEPJBAABG(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown(KeyCode.Greater))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x003DD4FC File Offset: 0x003DB6FC
		private void GFACKFCEIBC()
		{
			if (Input.GetKeyUp((KeyCode)(-43)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x003DD554 File Offset: 0x003DB754
		public void BBNADKBCING(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-59)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x003DD5A4 File Offset: 0x003DB7A4
		private void MJNPIDGNJMK()
		{
			if (Input.GetKeyUp(KeyCode.K) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x003DD5FC File Offset: 0x003DB7FC
		public void JAOGNMCFCKM()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void JFJLGJEPEAA()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x003DD64C File Offset: 0x003DB84C
		public void LJFNOGODEHD()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x003DD69C File Offset: 0x003DB89C
		public void PICODEJJEEA()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x003DD6EC File Offset: 0x003DB8EC
		private void HLDFOJMHKNL()
		{
			if (Input.GetKeyUp((KeyCode)(-53)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x003DD744 File Offset: 0x003DB944
		private void LKJMIODJGCM()
		{
			if (Input.GetKeyUp((KeyCode)(-43)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x003DD79C File Offset: 0x003DB99C
		private void OEENOOGEEHD()
		{
			if (Input.GetKeyUp((KeyCode)23) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x003DD7F4 File Offset: 0x003DB9F4
		public void MCBLGFAEJKD(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-10)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x003DD844 File Offset: 0x003DBA44
		public void DPEOKPEIOJH(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)76))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x003DD894 File Offset: 0x003DBA94
		private void PNLKFANNOKO()
		{
			if (Input.GetKeyUp(KeyCode.Quote) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void DBLILJGKGHJ()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x003DD8EC File Offset: 0x003DBAEC
		private void EJFJENFKLND()
		{
			if (Input.GetKeyUp((KeyCode)72) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void MMOKKAPFGAK()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x003DD944 File Offset: 0x003DBB44
		public void KFEPPBBKMBL()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void GLEJGFLCLPJ()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x003DD994 File Offset: 0x003DBB94
		private void FOLDLDLFFLM()
		{
			if (Input.GetKeyUp(KeyCode.I) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x003DD9EC File Offset: 0x003DBBEC
		public void LBMBLEDFIAF(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown(KeyCode.BackQuote))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void BGDPIHMAACO()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x003DDA3C File Offset: 0x003DBC3C
		private void KKLMPKLKAEM()
		{
			if (Input.GetKeyUp((KeyCode)(-97)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x003DDA94 File Offset: 0x003DBC94
		private void LMBDNPLDGIJ()
		{
			if (Input.GetKeyUp((KeyCode)(-113)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x003DDAEC File Offset: 0x003DBCEC
		public void EBDMEFJOLAO(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown(KeyCode.Question))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x003DDB3C File Offset: 0x003DBD3C
		public void GLCAILCKMDA(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown(KeyCode.Z))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x003DDB8C File Offset: 0x003DBD8C
		public void PBNAHLFCDGE(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown(KeyCode.N))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void DLBODOFAJGM()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x003DDBDC File Offset: 0x003DBDDC
		public void GGJNCMDEAEA()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x003DDC2C File Offset: 0x003DBE2C
		private void BGFJOEPFOPM()
		{
			if (Input.GetKeyUp((KeyCode)(-85)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x003DDC84 File Offset: 0x003DBE84
		private void OCMKCBBCEFG()
		{
			if (Input.GetKeyUp(KeyCode.Alpha8) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x003DDCDC File Offset: 0x003DBEDC
		private void KMKLDAJLCNM()
		{
			if (Input.GetKeyUp(KeyCode.Question) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x003DDD34 File Offset: 0x003DBF34
		private void LCJHDLKJEOM()
		{
			if (Input.GetKeyUp((KeyCode)74) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x003DDD8C File Offset: 0x003DBF8C
		private void AIJGAJIOJDJ()
		{
			if (Input.GetKeyUp((KeyCode)(-37)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x003DDDE4 File Offset: 0x003DBFE4
		public void JEPINIMEKKL(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-66)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x003DDE34 File Offset: 0x003DC034
		public void KLEKJEEFAMF(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-42)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void FDNONDCGGCG()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x003DDE84 File Offset: 0x003DC084
		public void HACEBFMDJKK(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)21))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x003DDED4 File Offset: 0x003DC0D4
		private void APKNAPHOFHC()
		{
			if (Input.GetKeyUp((KeyCode)11) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x003DDF2C File Offset: 0x003DC12C
		public void IAFLGDDFFGA()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void FANADGBGCPI()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x003DDF7C File Offset: 0x003DC17C
		private void FGNFILLNPJK()
		{
			if (Input.GetKeyUp(KeyCode.Alpha7) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x003DDFD4 File Offset: 0x003DC1D4
		private void JBMBNKOOENB()
		{
			if (Input.GetKeyUp((KeyCode)82) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x003DE02C File Offset: 0x003DC22C
		public void JDPLOBGEMFB(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-4)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x003DE07C File Offset: 0x003DC27C
		public void LBDONBHJNML()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x003DE0CC File Offset: 0x003DC2CC
		public void HLIGLFIAHFP()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x003DE11C File Offset: 0x003DC31C
		public void PGEHMFGPGEP(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-74)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x003DE16C File Offset: 0x003DC36C
		private void PKGJJFIFLII()
		{
			if (Input.GetKeyUp((KeyCode)67) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x003DE1C4 File Offset: 0x003DC3C4
		private void IBHACCEEFFI()
		{
			if (Input.GetKeyUp((KeyCode)(-47)) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x003DE21C File Offset: 0x003DC41C
		private void NFEDLAOPHML()
		{
			if (Input.GetKeyUp(KeyCode.Plus) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void Start()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x003DE274 File Offset: 0x003DC474
		public void NBPBPBFMLLM(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-113)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x003DE2C4 File Offset: 0x003DC4C4
		public void HPFBBCKNNAB()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x003DE314 File Offset: 0x003DC514
		public void HBEMMEDMAJM()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x003DE364 File Offset: 0x003DC564
		private void IKMELABKBHO()
		{
			if (Input.GetKeyUp((KeyCode)11) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x003DE3BC File Offset: 0x003DC5BC
		private void OIBMHPIFAKK()
		{
			if (Input.GetKeyUp((KeyCode)29) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x003DE414 File Offset: 0x003DC614
		public void HALDCGDOAIO(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)18))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void GPNAOAKCMHC()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x003DE464 File Offset: 0x003DC664
		public void HMPFLOEMHJF()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x003DE4B4 File Offset: 0x003DC6B4
		public void OPPAFOAIIOE(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-35)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x003DE504 File Offset: 0x003DC704
		public void PLNDGIFBOMA()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void ANCKKLFPGDI()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x003DE554 File Offset: 0x003DC754
		public void KDGAKEPDNDJ(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-103)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void KDMKDEKCELE()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x003DE5A4 File Offset: 0x003DC7A4
		public void DMFHJIDHHCE(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-122)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5EA RID: 42474 RVA: 0x003DE5F4 File Offset: 0x003DC7F4
		public void KGJBINHKFIH()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5EB RID: 42475 RVA: 0x003DE644 File Offset: 0x003DC844
		public void PHAPJNOJNKF()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5EC RID: 42476 RVA: 0x003DE694 File Offset: 0x003DC894
		private void Update()
		{
			if (Input.GetKeyUp(KeyCode.Return) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5ED RID: 42477 RVA: 0x003DE6EC File Offset: 0x003DC8EC
		public void FGHFHDHPAIF()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void MKOMIDCPCDC()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5EF RID: 42479 RVA: 0x003DE73C File Offset: 0x003DC93C
		public void PKHKFEKGHOO()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x003DE78C File Offset: 0x003DC98C
		public void BGONEKACDKD(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown(KeyCode.O))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = false;
			}
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x003DE7DC File Offset: 0x003DC9DC
		public void HHOJHJEODIG(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown((KeyCode)(-76)))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x003DE82C File Offset: 0x003DCA2C
		public void KBMBNDBPEOG()
		{
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (!flag)
			{
				this.JFMMLPEDDDO.Select();
				this.JFMMLPEDDDO.ActivateInputField();
			}
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void LFBGJIIECLD()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void FBPHNEJBDJN()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x003DE87C File Offset: 0x003DCA7C
		private void FBMDHDBELEK()
		{
			if (Input.GetKeyUp(KeyCode.Alpha1) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = false;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x003DE8D4 File Offset: 0x003DCAD4
		public void OnEndEdit(string CNBJGHGPPOA)
		{
			if (!Input.GetKeyDown(KeyCode.Return))
			{
				return;
			}
			bool flag = this.JFMMLPEDDDO.text == string.Empty;
			this.JFMMLPEDDDO.text = string.Empty;
			if (flag)
			{
				this._ignoreNextActivation = true;
			}
		}

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x003DCA8D File Offset: 0x003DAC8D
		private void KOFAMEKHHGD()
		{
			this.JFMMLPEDDDO = base.GetComponent<InputField>();
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x003DE924 File Offset: 0x003DCB24
		private void PBEPCAPAKLG()
		{
			if (Input.GetKeyUp((KeyCode)30) && !this.JFMMLPEDDDO.isFocused)
			{
				if (this._ignoreNextActivation)
				{
					this._ignoreNextActivation = true;
				}
				else
				{
					this.JFMMLPEDDDO.Select();
					this.JFMMLPEDDDO.ActivateInputField();
				}
			}
		}

		// Token: 0x040012A3 RID: 4771
		protected InputField JFMMLPEDDDO;

		// Token: 0x040012A4 RID: 4772
		public bool _ignoreNextActivation;
	}
}
