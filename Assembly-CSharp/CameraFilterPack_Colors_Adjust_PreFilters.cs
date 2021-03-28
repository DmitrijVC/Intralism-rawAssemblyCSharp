using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000079 RID: 121
[AddComponentMenu("Camera Filter Pack/ColorsAdjust/Photo Filters")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_Adjust_PreFilters : MonoBehaviour
{
	// Token: 0x06002293 RID: 8851 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x000C7AC7 File Offset: 0x000C5CC7
	private void KIMMMCJFMAB()
	{
		this.GPHHNFDCFMC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x000C7AF4 File Offset: 0x000C5CF4
	private void MIPGPMKJELI()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				0f,
				0f,
				0f,
				100f,
				0f,
				0f,
				0f,
				100f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Deuteranomaly)
		{
			this.PLKFKNHPEHE = new float[]
			{
				80f,
				20f,
				0f,
				25.833f,
				74.167f,
				0f,
				0f,
				14.167f,
				85.833f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Protanopia)
		{
			this.PLKFKNHPEHE = new float[]
			{
				56.667f,
				43.333f,
				0f,
				55.833f,
				44.167f,
				0f,
				0f,
				24.167f,
				75.833f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Protanomaly)
		{
			this.PLKFKNHPEHE = new float[]
			{
				81.667f,
				18.333f,
				0f,
				33.333f,
				66.667f,
				0f,
				0f,
				12.5f,
				87.5f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Deuteranopia)
		{
			this.PLKFKNHPEHE = new float[]
			{
				62.5f,
				37.5f,
				0f,
				70f,
				30f,
				0f,
				0f,
				30f,
				70f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Tritanomaly)
		{
			this.PLKFKNHPEHE = new float[]
			{
				96.667f,
				3.333f,
				0f,
				0f,
				73.333f,
				26.667f,
				0f,
				18.333f,
				81.667f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Achromatopsia)
		{
			this.PLKFKNHPEHE = new float[]
			{
				29.9f,
				58.7f,
				11.4f,
				29.9f,
				58.7f,
				11.4f,
				29.9f,
				58.7f,
				11.4f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Achromatomaly)
		{
			this.PLKFKNHPEHE = new float[]
			{
				61.8f,
				32f,
				6.2f,
				16.3f,
				77.5f,
				6.2f,
				16.3f,
				32f,
				51.6f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Tritanopia)
		{
			this.PLKFKNHPEHE = new float[]
			{
				95f,
				5f,
				0f,
				0f,
				43.333f,
				56.667f,
				0f,
				47.5f,
				52.5f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				102f,
				0f,
				18f,
				100f,
				4f,
				28f,
				-26f,
				100f,
				-64f,
				0f,
				12f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			this.PLKFKNHPEHE = new float[]
			{
				70f,
				200f,
				0f,
				0f,
				100f,
				8f,
				6f,
				12f,
				110f,
				0f,
				0f,
				-6f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			this.PLKFKNHPEHE = new float[]
			{
				200f,
				98f,
				-116f,
				24f,
				100f,
				2f,
				30f,
				52f,
				20f,
				-48f,
				-20f,
				12f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			this.PLKFKNHPEHE = new float[]
			{
				60f,
				112f,
				36f,
				24f,
				100f,
				2f,
				0f,
				-26f,
				100f,
				-56f,
				-20f,
				12f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			this.PLKFKNHPEHE = new float[]
			{
				-42f,
				68f,
				108f,
				-96f,
				100f,
				116f,
				-92f,
				104f,
				96f,
				0f,
				2f,
				4f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			this.PLKFKNHPEHE = new float[]
			{
				200f,
				109f,
				-104f,
				42f,
				126f,
				-1f,
				-40f,
				121f,
				-31f,
				-48f,
				-20f,
				12f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			this.PLKFKNHPEHE = new float[]
			{
				130f,
				8f,
				7f,
				19f,
				89f,
				3f,
				-1f,
				11f,
				57f,
				10f,
				19f,
				47f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.PopRocket)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				6f,
				-17f,
				0f,
				107f,
				0f,
				10f,
				21f,
				100f,
				40f,
				0f,
				8f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedSoftLight)
		{
			this.PLKFKNHPEHE = new float[]
			{
				-4f,
				200f,
				-30f,
				-58f,
				200f,
				-30f,
				-58f,
				200f,
				-30f,
				-11f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Blue)
		{
			this.PLKFKNHPEHE = new float[]
			{
				0f,
				0f,
				100f,
				0f,
				0f,
				100f,
				0f,
				0f,
				100f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Green)
		{
			this.PLKFKNHPEHE = new float[]
			{
				0f,
				100f,
				0f,
				0f,
				100f,
				0f,
				0f,
				100f,
				0f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Orange)
		{
			this.PLKFKNHPEHE = new float[]
			{
				50f,
				50f,
				0f,
				50f,
				50f,
				0f,
				50f,
				50f,
				0f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Red)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				0f,
				0f,
				100f,
				0f,
				0f,
				100f,
				0f,
				0f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Yellow)
		{
			this.PLKFKNHPEHE = new float[]
			{
				34f,
				66f,
				0f,
				34f,
				66f,
				0f,
				34f,
				66f,
				0f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.YellowSunSet)
		{
			this.PLKFKNHPEHE = new float[]
			{
				117f,
				-6f,
				53f,
				-68f,
				135f,
				19f,
				-146f,
				-61f,
				200f,
				0f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Walden)
		{
			this.PLKFKNHPEHE = new float[]
			{
				99f,
				2f,
				13f,
				100f,
				1f,
				40f,
				50f,
				8f,
				71f,
				0f,
				2f,
				7f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.WhiteShine)
		{
			this.PLKFKNHPEHE = new float[]
			{
				190f,
				24f,
				-33f,
				2f,
				200f,
				-6f,
				-10f,
				27f,
				200f,
				-6f,
				-13f,
				15f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Fluo)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				0f,
				0f,
				0f,
				113f,
				0f,
				200f,
				-200f,
				-200f,
				0f,
				0f,
				36f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.MarsSunRise)
		{
			this.PLKFKNHPEHE = new float[]
			{
				50f,
				141f,
				-81f,
				-17f,
				62f,
				29f,
				-159f,
				-137f,
				-200f,
				7f,
				-34f,
				-6f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Amelie)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				11f,
				39f,
				1f,
				63f,
				53f,
				-24f,
				71f,
				20f,
				-25f,
				-10f,
				-24f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueJeans)
		{
			this.PLKFKNHPEHE = new float[]
			{
				181f,
				11f,
				15f,
				40f,
				40f,
				20f,
				40f,
				40f,
				20f,
				-59f,
				0f,
				0f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NightVision)
		{
			this.PLKFKNHPEHE = new float[]
			{
				200f,
				-200f,
				-200f,
				195f,
				4f,
				-160f,
				200f,
				-200f,
				-200f,
				-200f,
				10f,
				-200f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueParadise)
		{
			this.PLKFKNHPEHE = new float[]
			{
				66f,
				200f,
				-200f,
				25f,
				38f,
				36f,
				30f,
				150f,
				114f,
				17f,
				0f,
				65f
			};
		}
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x000C7F98 File Offset: 0x000C6198
	private void POPFEPMJDPF()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[-75];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-6))
		{
			float[] array2 = new float[58];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-104))
		{
			float[] array3 = new float[101];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)62)
		{
			float[] array4 = new float[102];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-26))
		{
			float[] array5 = new float[-94];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-98))
		{
			float[] array6 = new float[119];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-17))
		{
			float[] array7 = new float[-93];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-125))
		{
			float[] array8 = new float[-63];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)42)
		{
			float[] array9 = new float[102];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array10 = new float[-80];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.PopRocket)
		{
			float[] array11 = new float[-125];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			float[] array12 = new float[-16];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.PopRocket)
		{
			float[] array13 = new float[29];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			float[] array14 = new float[-89];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array15 = new float[-60];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array16 = new float[120];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array17 = new float[59];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)51)
		{
			float[] array18 = new float[-51];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)99)
		{
			float[] array19 = new float[63];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)52)
		{
			float[] array20 = new float[78];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)78)
		{
			this.PLKFKNHPEHE = new float[]
			{
				50f,
				50f,
				0f,
				50f,
				50f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)117)
		{
			float[] array21 = new float[-109];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-54))
		{
			float[] array22 = new float[118];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-80))
		{
			float[] array23 = new float[48];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)105)
		{
			float[] array24 = new float[73];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)96)
		{
			float[] array25 = new float[-60];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-58))
		{
			float[] array26 = new float[-120];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)115)
		{
			float[] array27 = new float[-75];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Fluo)
		{
			float[] array28 = new float[63];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-121))
		{
			float[] array29 = new float[74];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-126))
		{
			float[] array30 = new float[127];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-79))
		{
			float[] array31 = new float[24];
			RuntimeHelpers.InitializeArray(array31, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array31;
		}
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x000C843B File Offset: 0x000C663B
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002298 RID: 8856 RVA: 0x000C8458 File Offset: 0x000C6658
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x000C8490 File Offset: 0x000C6690
	private void LBEHKFNPKMC()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[-76];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)103)
		{
			float[] array2 = new float[-117];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)114)
		{
			float[] array3 = new float[110];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)38)
		{
			float[] array4 = new float[83];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Tritanopia)
		{
			float[] array5 = new float[-115];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)44)
		{
			float[] array6 = new float[-105];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)51)
		{
			float[] array7 = new float[-118];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-3))
		{
			float[] array8 = new float[-16];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)96)
		{
			float[] array9 = new float[70];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array10 = new float[117];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.PopRocket)
		{
			float[] array11 = new float[-67];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.PopRocket)
		{
			float[] array12 = new float[-9];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array13 = new float[-55];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			float[] array14 = new float[96];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array15 = new float[13];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array16 = new float[54];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			float[] array17 = new float[-15];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-29))
		{
			float[] array18 = new float[-63];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)101)
		{
			float[] array19 = new float[-75];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-42))
		{
			float[] array20 = new float[49];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)102)
		{
			float[] array21 = new float[-106];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-21))
		{
			float[] array22 = new float[-101];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Orange)
		{
			float[] array23 = new float[-3];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-3))
		{
			float[] array24 = new float[91];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-87))
		{
			float[] array25 = new float[-55];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)89)
		{
			float[] array26 = new float[-45];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-72))
		{
			float[] array27 = new float[-72];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-65))
		{
			this.PLKFKNHPEHE = new float[]
			{
				50f,
				141f,
				-81f,
				-17f,
				62f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)115)
		{
			float[] array28 = new float[-10];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)39)
		{
			float[] array29 = new float[48];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-119))
		{
			float[] array30 = new float[-15];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-4))
		{
			float[] array31 = new float[104];
			RuntimeHelpers.InitializeArray(array31, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array31;
		}
	}

	// Token: 0x0600229B RID: 8859 RVA: 0x000C895C File Offset: 0x000C6B5C
	private void FIKFJDFELIP()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600229C RID: 8860 RVA: 0x000C843B File Offset: 0x000C663B
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600229D RID: 8861 RVA: 0x000C843B File Offset: 0x000C663B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600229E RID: 8862 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0600229F RID: 8863 RVA: 0x000C8987 File Offset: 0x000C6B87
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022A0 RID: 8864 RVA: 0x000C89C0 File Offset: 0x000C6BC0
	private void DJGJOMFJPEF()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[36];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)44)
		{
			float[] array2 = new float[-53];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)82)
		{
			float[] array3 = new float[-47];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-3))
		{
			float[] array4 = new float[100];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-25))
		{
			float[] array5 = new float[104];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-91))
		{
			float[] array6 = new float[-12];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-52))
		{
			float[] array7 = new float[56];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-65))
		{
			float[] array8 = new float[35];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)58)
		{
			float[] array9 = new float[72];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array10 = new float[-124];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array11 = new float[63];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array12 = new float[-76];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			float[] array13 = new float[-49];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array14 = new float[-5];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array15 = new float[103];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array16 = new float[121];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array17 = new float[-75];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-60))
		{
			float[] array18 = new float[32];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)41)
		{
			float[] array19 = new float[112];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-19))
		{
			float[] array20 = new float[35];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-102))
		{
			float[] array21 = new float[-56];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)115)
		{
			float[] array22 = new float[-107];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)122)
		{
			float[] array23 = new float[-78];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Orange)
		{
			float[] array24 = new float[111];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)86)
		{
			float[] array25 = new float[92];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Protanopia)
		{
			float[] array26 = new float[36];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Amelie)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				0f,
				0f,
				0f,
				113f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-31))
		{
			float[] array27 = new float[-57];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)105)
		{
			float[] array28 = new float[-10];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-121))
		{
			float[] array29 = new float[-79];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)40)
		{
			this.PLKFKNHPEHE = new float[]
			{
				200f,
				-200f,
				-200f,
				195f,
				4f,
				-160f,
				200f,
				-200f,
				-200f,
				-200f,
				10f,
				-200f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-10))
		{
			float[] array30 = new float[67];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
	}

	// Token: 0x060022A1 RID: 8865 RVA: 0x000C8E64 File Offset: 0x000C7064
	private void HEDFBCFGDLF()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[21];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)43)
		{
			float[] array2 = new float[23];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-19))
		{
			float[] array3 = new float[127];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)115)
		{
			float[] array4 = new float[-124];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Orange)
		{
			float[] array5 = new float[93];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-100))
		{
			float[] array6 = new float[28];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-123))
		{
			float[] array7 = new float[70];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-72))
		{
			float[] array8 = new float[43];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-43))
		{
			float[] array9 = new float[121];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array10 = new float[91];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array11 = new float[-128];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			float[] array12 = new float[-40];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			float[] array13 = new float[78];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array14 = new float[-51];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array15 = new float[-41];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array16 = new float[98];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array17 = new float[14];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)127)
		{
			float[] array18 = new float[-128];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-8))
		{
			float[] array19 = new float[54];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)35)
		{
			float[] array20 = new float[-3];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)115)
		{
			float[] array21 = new float[95];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-103))
		{
			float[] array22 = new float[-36];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)52)
		{
			float[] array23 = new float[-66];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-53))
		{
			float[] array24 = new float[27];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-84))
		{
			float[] array25 = new float[89];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-101))
		{
			float[] array26 = new float[59];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)41)
		{
			float[] array27 = new float[-92];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-86))
		{
			float[] array28 = new float[-59];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-100))
		{
			float[] array29 = new float[-99];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Achromatopsia)
		{
			float[] array30 = new float[-20];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array31 = new float[-67];
			RuntimeHelpers.InitializeArray(array31, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array31;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-32))
		{
			float[] array32 = new float[-97];
			RuntimeHelpers.InitializeArray(array32, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array32;
		}
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x000C9307 File Offset: 0x000C7507
	private void FINDGJLEHOL()
	{
		this.DAJPHCOFNMG();
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x000C930F File Offset: 0x000C750F
	private void CNGAJDBOCLJ()
	{
		this.DAJPHCOFNMG();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x000C933A File Offset: 0x000C753A
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x000C843B File Offset: 0x000C663B
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x000C9374 File Offset: 0x000C7574
	private void GPHHNFDCFMC()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[-4];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)72)
		{
			float[] array2 = new float[-112];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)33)
		{
			float[] array3 = new float[-96];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-61))
		{
			float[] array4 = new float[-62];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)74)
		{
			float[] array5 = new float[71];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-113))
		{
			float[] array6 = new float[-25];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-101))
		{
			float[] array7 = new float[-53];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array8 = new float[102];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)39)
		{
			float[] array9 = new float[61];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				102f,
				0f,
				18f,
				100f,
				4f,
				28f,
				-26f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array10 = new float[67];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array11 = new float[-72];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.PopRocket)
		{
			float[] array12 = new float[-77];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array13 = new float[57];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			float[] array14 = new float[-92];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array15 = new float[70];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array16 = new float[-18];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-3))
		{
			float[] array17 = new float[-40];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)108)
		{
			float[] array18 = new float[-2];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-5))
		{
			float[] array19 = new float[-104];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.YellowSunSet)
		{
			float[] array20 = new float[91];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-1))
		{
			float[] array21 = new float[-112];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-40))
		{
			float[] array22 = new float[24];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-64))
		{
			float[] array23 = new float[84];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-94))
		{
			float[] array24 = new float[70];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)92)
		{
			float[] array25 = new float[18];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-112))
		{
			float[] array26 = new float[13];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)59)
		{
			float[] array27 = new float[-4];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-45))
		{
			float[] array28 = new float[-38];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueParadise)
		{
			float[] array29 = new float[-55];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-76))
		{
			float[] array30 = new float[68];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)70)
		{
			float[] array31 = new float[49];
			RuntimeHelpers.InitializeArray(array31, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array31;
		}
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x000C9817 File Offset: 0x000C7A17
	private void LOOGLMFBJHK()
	{
		this.MHNCEEDIKCC();
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x000C981F File Offset: 0x000C7A1F
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x000C843B File Offset: 0x000C663B
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x000C9856 File Offset: 0x000C7A56
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x000C843B File Offset: 0x000C663B
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x000C843B File Offset: 0x000C663B
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x000C843B File Offset: 0x000C663B
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x000C9890 File Offset: 0x000C7A90
	private void HBFMIBFLMJP()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[-110];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-4))
		{
			float[] array2 = new float[54];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)92)
		{
			float[] array3 = new float[56];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-36))
		{
			float[] array4 = new float[-60];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-31))
		{
			this.PLKFKNHPEHE = new float[]
			{
				62.5f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-74))
		{
			float[] array5 = new float[-120];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			this.PLKFKNHPEHE = new float[]
			{
				29.9f,
				58.7f,
				11.4f,
				29.9f,
				58.7f,
				11.4f,
				29.9f,
				58.7f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)34)
		{
			float[] array6 = new float[-22];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)84)
		{
			float[] array7 = new float[48];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array8 = new float[-42];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array9 = new float[115];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array10 = new float[-5];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array11 = new float[60];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array12 = new float[-50];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array13 = new float[25];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array14 = new float[64];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			float[] array15 = new float[-91];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-95))
		{
			float[] array16 = new float[104];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-112))
		{
			float[] array17 = new float[113];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-30))
		{
			float[] array18 = new float[32];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)64)
		{
			float[] array19 = new float[126];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-89))
		{
			float[] array20 = new float[54];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-65))
		{
			float[] array21 = new float[-117];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-8))
		{
			float[] array22 = new float[67];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			this.PLKFKNHPEHE = new float[]
			{
				99f,
				2f,
				13f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-100))
		{
			float[] array23 = new float[120];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)47)
		{
			float[] array24 = new float[107];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-112))
		{
			float[] array25 = new float[-9];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)77)
		{
			float[] array26 = new float[-42];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Protanopia)
		{
			float[] array27 = new float[116];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)39)
		{
			float[] array28 = new float[-21];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)97)
		{
			float[] array29 = new float[65];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x000C9D34 File Offset: 0x000C7F34
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 818f)
			{
				this.HBJJOCHGOPH = 78f;
			}
			this.BFGNMFCNDBC().SetFloat("Left ", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("MaxLivesSlider", this.PLKFKNHPEHE[0] / 1768f);
			this.HFBJAOFLCJI().SetFloat("SetParticlesEmission", this.PLKFKNHPEHE[1] / 1383f);
			this.PDEAHJPOMEF().SetFloat("Tab2Content", this.PLKFKNHPEHE[0] / 886f);
			this.NBPKMLMCHFN.SetFloat("_Green_R", this.PLKFKNHPEHE[0] / 412f);
			this.HKGAONMOBMH().SetFloat("_FlipAlphaMask", this.PLKFKNHPEHE[4] / 775f);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.PLKFKNHPEHE[4] / 1038f);
			this.PGPEMMBJOOG().SetFloat("Ev DestroyAll! By PlayerId: ", this.PLKFKNHPEHE[3] / 557f);
			this.NBPKMLMCHFN.SetFloat("_Far", this.PLKFKNHPEHE[2] / 1412f);
			this.PDEAHJPOMEF().SetFloat("Reading preview file failed!: \"{0}\"", this.PLKFKNHPEHE[2] / 458f);
			this.FAIFBBGFAIB().SetFloat("#rt", this.PLKFKNHPEHE[53] / 1284f);
			this.HKGAONMOBMH().SetFloat("Joystick1Button0", this.PLKFKNHPEHE[-109] / 600f);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_PinLight", this.PLKFKNHPEHE[-70] / 229f);
			this.PGPEMMBJOOG().SetFloat("DPADVER", this.FadeFX);
			this.HFBJAOFLCJI().SetVector("SendVacantViewIds()", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 935f, 537f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x000C9F5C File Offset: 0x000C815C
	private void OnValidate()
	{
		this.MIPGPMKJELI();
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x000C895C File Offset: 0x000C6B5C
	private void DAHFFNNIGML()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x000C9F64 File Offset: 0x000C8164
	private void DAJPHCOFNMG()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			this.PLKFKNHPEHE = new float[]
			{
				100f,
				0f,
				0f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)40)
		{
			float[] array = new float[-111];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)121)
		{
			float[] array2 = new float[-32];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)58)
		{
			float[] array3 = new float[77];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-32))
		{
			float[] array4 = new float[64];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)72)
		{
			float[] array5 = new float[-41];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-107))
		{
			float[] array6 = new float[-82];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-123))
		{
			float[] array7 = new float[49];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-8))
		{
			float[] array8 = new float[52];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array9 = new float[80];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			this.PLKFKNHPEHE = new float[]
			{
				70f
			};
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			float[] array10 = new float[36];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array11 = new float[-3];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array12 = new float[36];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array13 = new float[-100];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array14 = new float[-111];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array15 = new float[27];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)108)
		{
			float[] array16 = new float[103];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-75))
		{
			float[] array17 = new float[-19];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-90))
		{
			float[] array18 = new float[-89];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)34)
		{
			float[] array19 = new float[-121];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-51))
		{
			float[] array20 = new float[-45];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)41)
		{
			float[] array21 = new float[67];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)67)
		{
			float[] array22 = new float[-8];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)85)
		{
			float[] array23 = new float[111];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)54)
		{
			float[] array24 = new float[24];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)54)
		{
			float[] array25 = new float[-125];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)48)
		{
			float[] array26 = new float[-86];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)74)
		{
			float[] array27 = new float[-115];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-91))
		{
			float[] array28 = new float[-111];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-85))
		{
			float[] array29 = new float[-51];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)38)
		{
			float[] array30 = new float[-72];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x000CA408 File Offset: 0x000C8608
	private void KPBEDPFEKFI()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[52];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-85))
		{
			this.PLKFKNHPEHE = new float[]
			{
				80f
			};
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)109)
		{
			float[] array2 = new float[-96];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-76))
		{
			float[] array3 = new float[104];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-54))
		{
			float[] array4 = new float[37];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-18))
		{
			float[] array5 = new float[-98];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)70)
		{
			float[] array6 = new float[74];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)53)
		{
			float[] array7 = new float[104];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-58))
		{
			float[] array8 = new float[-91];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array9 = new float[46];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array10 = new float[-74];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array11 = new float[-26];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array12 = new float[-80];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array13 = new float[94];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array14 = new float[85];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array15 = new float[-82];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array16 = new float[125];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-35))
		{
			float[] array17 = new float[44];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)116)
		{
			float[] array18 = new float[-90];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)71)
		{
			float[] array19 = new float[-58];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-72))
		{
			float[] array20 = new float[-59];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)93)
		{
			float[] array21 = new float[-94];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-99))
		{
			float[] array22 = new float[-22];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-107))
		{
			float[] array23 = new float[117];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)40)
		{
			float[] array24 = new float[45];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-57))
		{
			float[] array25 = new float[84];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-111))
		{
			float[] array26 = new float[28];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-103))
		{
			float[] array27 = new float[-120];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)113)
		{
			float[] array28 = new float[-83];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-92))
		{
			float[] array29 = new float[-63];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-84))
		{
			float[] array30 = new float[-114];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-96))
		{
			float[] array31 = new float[-125];
			RuntimeHelpers.InitializeArray(array31, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array31;
		}
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x000CA8AC File Offset: 0x000C8AAC
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 424f)
			{
				this.HBJJOCHGOPH = 1478f;
			}
			this.PGPEMMBJOOG().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Far", this.PLKFKNHPEHE[1] / 1892f);
			this.PGPEMMBJOOG().SetFloat("Preparing configuration", this.PLKFKNHPEHE[0] / 820f);
			this.HKGAONMOBMH().SetFloat("_TimeX", this.PLKFKNHPEHE[0] / 1650f);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[3] / 24f);
			this.BFGNMFCNDBC().SetFloat("PointerEnter ", this.PLKFKNHPEHE[2] / 494f);
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[4] / 1927f);
			this.HFBJAOFLCJI().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", this.PLKFKNHPEHE[3] / 245f);
			this.HFBJAOFLCJI().SetFloat(" does not exist!", this.PLKFKNHPEHE[1] / 759f);
			this.HKGAONMOBMH().SetFloat(" not exist", this.PLKFKNHPEHE[2] / 674f);
			this.PDEAHJPOMEF().SetFloat("_Value1", this.PLKFKNHPEHE[37] / 1139f);
			this.HKGAONMOBMH().SetFloat("_Far", this.PLKFKNHPEHE[18] / 222f);
			this.HFBJAOFLCJI().SetFloat("Case-Sensitive", this.PLKFKNHPEHE[-10] / 1134f);
			this.HFBJAOFLCJI().SetFloat("GlassDistortion", this.FadeFX);
			this.FAIFBBGFAIB().SetVector("ControllerLeftY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 551f, 296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022BA RID: 8890 RVA: 0x000CAAD4 File Offset: 0x000C8CD4
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1100f)
			{
				this.HBJJOCHGOPH = 945f;
			}
			this.HKGAONMOBMH().SetFloat("?", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("settings.enablehitsoundsinnormal", this.PLKFKNHPEHE[0] / 1721f);
			this.FAIFBBGFAIB().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", this.PLKFKNHPEHE[0] / 1932f);
			this.HKGAONMOBMH().SetFloat("_Value1", this.PLKFKNHPEHE[2] / 325f);
			this.BFGNMFCNDBC().SetFloat("ScoreText", this.PLKFKNHPEHE[7] / 218f);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this.PLKFKNHPEHE[3] / 637f);
			this.HFBJAOFLCJI().SetFloat("EnableRankingToggle", this.PLKFKNHPEHE[0] / 1293f);
			this.NBPKMLMCHFN.SetFloat("#ok", this.PLKFKNHPEHE[3] / 1881f);
			this.FAIFBBGFAIB().SetFloat("_Color", this.PLKFKNHPEHE[4] / 32f);
			this.FAIFBBGFAIB().SetFloat("_SizeY", this.PLKFKNHPEHE[5] / 1370f);
			this.HKGAONMOBMH().SetFloat("_BlurSize", this.PLKFKNHPEHE[-116] / 1876f);
			this.BFGNMFCNDBC().SetFloat("(\\[ *i *\\])", this.PLKFKNHPEHE[-74] / 495f);
			this.PGPEMMBJOOG().SetFloat("_Value", this.PLKFKNHPEHE[-64] / 1471f);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.FadeFX);
			this.BFGNMFCNDBC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1032f, 1359f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x000CACFC File Offset: 0x000C8EFC
	private void NIPKMFJEACH()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[97];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)74)
		{
			float[] array2 = new float[-55];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Blindness_Deuteranopia)
		{
			float[] array3 = new float[114];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-112))
		{
			float[] array4 = new float[-83];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)58)
		{
			float[] array5 = new float[-71];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)56)
		{
			float[] array6 = new float[-60];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)83)
		{
			float[] array7 = new float[-21];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-80))
		{
			float[] array8 = new float[110];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-56))
		{
			float[] array9 = new float[57];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array10 = new float[113];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array11 = new float[94];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.NashVille)
		{
			float[] array12 = new float[-28];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.PopRocket)
		{
			float[] array13 = new float[-122];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueMoon)
		{
			float[] array14 = new float[39];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array15 = new float[45];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array16 = new float[80];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			float[] array17 = new float[-4];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array18 = new float[71];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)36)
		{
			float[] array19 = new float[-40];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-46))
		{
			float[] array20 = new float[21];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)83)
		{
			float[] array21 = new float[-66];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-96))
		{
			float[] array22 = new float[122];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)93)
		{
			float[] array23 = new float[25];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-54))
		{
			float[] array24 = new float[114];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)42)
		{
			float[] array25 = new float[109];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-31))
		{
			float[] array26 = new float[67];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-106))
		{
			float[] array27 = new float[-109];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-110))
		{
			float[] array28 = new float[-25];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-12))
		{
			float[] array29 = new float[-51];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)66)
		{
			float[] array30 = new float[78];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-51))
		{
			float[] array31 = new float[56];
			RuntimeHelpers.InitializeArray(array31, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array31;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)91)
		{
			float[] array32 = new float[-91];
			RuntimeHelpers.InitializeArray(array32, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array32;
		}
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x000C843B File Offset: 0x000C663B
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x000C895C File Offset: 0x000C6B5C
	private void Start()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022BE RID: 8894 RVA: 0x000CB1A0 File Offset: 0x000C93A0
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Red_R", this.PLKFKNHPEHE[0] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_G", this.PLKFKNHPEHE[1] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_B", this.PLKFKNHPEHE[2] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_R", this.PLKFKNHPEHE[3] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.PLKFKNHPEHE[4] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_B", this.PLKFKNHPEHE[5] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_R", this.PLKFKNHPEHE[6] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_G", this.PLKFKNHPEHE[7] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_B", this.PLKFKNHPEHE[8] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_C", this.PLKFKNHPEHE[9] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_C", this.PLKFKNHPEHE[10] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_C", this.PLKFKNHPEHE[11] / 100f);
			this.NBPKMLMCHFN.SetFloat("_FadeFX", this.FadeFX);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060022BF RID: 8895 RVA: 0x000CB3C8 File Offset: 0x000C95C8
	private Material NBPKMLMCHFN
	{
		get
		{
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.BJFKDHHMLJH;
		}
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x000C9F5C File Offset: 0x000C815C
	private void MLAGEPNCCGM()
	{
		this.MIPGPMKJELI();
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x000CB3FF File Offset: 0x000C95FF
	private void KMCPMOGKDEH()
	{
		this.LBEHKFNPKMC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x000CB42C File Offset: 0x000C962C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1183f)
			{
				this.HBJJOCHGOPH = 1284f;
			}
			this.HFBJAOFLCJI().SetFloat("\\n", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 1119f);
			this.FAIFBBGFAIB().SetFloat("_AlphaMask", this.PLKFKNHPEHE[1] / 875f);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button0", this.PLKFKNHPEHE[4] / 1146f);
			this.FAIFBBGFAIB().SetFloat("MenuVolumeSlider", this.PLKFKNHPEHE[8] / 1976f);
			this.FAIFBBGFAIB().SetFloat("_MainTexBlurred", this.PLKFKNHPEHE[8] / 1917f);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[0] / 106f);
			this.FAIFBBGFAIB().SetFloat("gamemode", this.PLKFKNHPEHE[7] / 1584f);
			this.HFBJAOFLCJI().SetFloat("player.bluebat", this.PLKFKNHPEHE[8] / 979f);
			this.HFBJAOFLCJI().SetFloat("_Value4", this.PLKFKNHPEHE[4] / 834f);
			this.PDEAHJPOMEF().SetFloat("effector", this.PLKFKNHPEHE[80] / 1706f);
			this.HKGAONMOBMH().SetFloat("GameScene", this.PLKFKNHPEHE[-89] / 712f);
			this.PDEAHJPOMEF().SetFloat("_FadeDistance", this.PLKFKNHPEHE[93] / 196f);
			this.PGPEMMBJOOG().SetFloat("id", this.FadeFX);
			this.FAIFBBGFAIB().SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 887f, 348f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x000CB654 File Offset: 0x000C9854
	private void IHLMNAGPKDA()
	{
		this.MHNCEEDIKCC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x000CB67F File Offset: 0x000C987F
	private void FHGKIOOMMOH()
	{
		this.POPFEPMJDPF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x000CB6AA File Offset: 0x000C98AA
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x000CB6E1 File Offset: 0x000C98E1
	private void GPNAOAKCMHC()
	{
		this.DJGJOMFJPEF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x000CB70C File Offset: 0x000C990C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1215f)
			{
				this.HBJJOCHGOPH = 1080f;
			}
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/3D_Binary", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("z", this.PLKFKNHPEHE[0] / 1978f);
			this.PGPEMMBJOOG().SetFloat("skins", this.PLKFKNHPEHE[1] / 1612f);
			this.HKGAONMOBMH().SetFloat("Destroying GO as global. ID: ", this.PLKFKNHPEHE[3] / 771f);
			this.NBPKMLMCHFN.SetFloat("/", this.PLKFKNHPEHE[5] / 349f);
			this.BFGNMFCNDBC().SetFloat("_ColoredChange", this.PLKFKNHPEHE[7] / 1717f);
			this.PGPEMMBJOOG().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", this.PLKFKNHPEHE[1] / 333f);
			this.HKGAONMOBMH().SetFloat("owner: ", this.PLKFKNHPEHE[7] / 116f);
			this.FAIFBBGFAIB().SetFloat("#join", this.PLKFKNHPEHE[7] / 544f);
			this.NBPKMLMCHFN.SetFloat("B", this.PLKFKNHPEHE[8] / 1434f);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.PLKFKNHPEHE[-8] / 845f);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.PLKFKNHPEHE[-61] / 512f);
			this.PGPEMMBJOOG().SetFloat("EnableRankingToggle", this.PLKFKNHPEHE[-5] / 251f);
			this.FAIFBBGFAIB().SetFloat("tolobby", this.FadeFX);
			this.BFGNMFCNDBC().SetVector("_BlurPass", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 512f, 843f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022C9 RID: 8905 RVA: 0x000CB934 File Offset: 0x000C9B34
	private void MHNCEEDIKCC()
	{
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.Normal)
		{
			float[] array = new float[-3];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-0125CC3CB136D2FA245C4B85C2B0EDA357F976C3).FieldHandle);
			this.PLKFKNHPEHE = array;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.GoldenPink)
		{
			float[] array2 = new float[-38];
			RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.$field-5F0F8562ECAB46015A377BBE282490A19F0164D7).FieldHandle);
			this.PLKFKNHPEHE = array2;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueJeans)
		{
			float[] array3 = new float[-85];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-63C38CD92581EEB7189BC4C9738BBF9079AEC77A).FieldHandle);
			this.PLKFKNHPEHE = array3;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-119))
		{
			float[] array4 = new float[-13];
			RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.$field-D6BCEA1F23E790402D02C5AAC11CD0E018D5EAA3).FieldHandle);
			this.PLKFKNHPEHE = array4;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)46)
		{
			float[] array5 = new float[-65];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-41BD997428945D4720C58D70D44CC33BE33830E1).FieldHandle);
			this.PLKFKNHPEHE = array5;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-42))
		{
			float[] array6 = new float[94];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-3990806C4EC965959471F976F01BD62DD6EC7AF0).FieldHandle);
			this.PLKFKNHPEHE = array6;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-71))
		{
			float[] array7 = new float[98];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-0A5C490B2B4D7E051515AB3DBCC5C56EEA300332).FieldHandle);
			this.PLKFKNHPEHE = array7;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)67)
		{
			float[] array8 = new float[45];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-FFC8121487AF9451D4B73A6DAD025EA3246C005E).FieldHandle);
			this.PLKFKNHPEHE = array8;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-33))
		{
			float[] array9 = new float[-14];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-655D75DB7343EE81A1995BDA0CB58AA7D072DA6F).FieldHandle);
			this.PLKFKNHPEHE = array9;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array10 = new float[85];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-4FC78C8A04547A82EE4015A7FEEB16E9498EF5CE).FieldHandle);
			this.PLKFKNHPEHE = array10;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlueLagoon)
		{
			float[] array11 = new float[-118];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-0593A81B07DBEE4DA7A5B9C792B9D1B2EC819292).FieldHandle);
			this.PLKFKNHPEHE = array11;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array12 = new float[-18];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-DA21F7BB7D0AE92A3EF493034E070DE6B642D59B).FieldHandle);
			this.PLKFKNHPEHE = array12;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array13 = new float[106];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-6712D4F9045448650DFF096DD5C2DABFFD91881F).FieldHandle);
			this.PLKFKNHPEHE = array13;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array14 = new float[68];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-5919ACCD1AED3463E3F7B2E10E4105E2A7276519).FieldHandle);
			this.PLKFKNHPEHE = array14;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.DarkPink)
		{
			float[] array15 = new float[-121];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-B10D4E6D0E1086A222C77A3DDA04CE89FF28B832).FieldHandle);
			this.PLKFKNHPEHE = array15;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.RedWhite)
		{
			float[] array16 = new float[-87];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-89147A6AF97A1EAAA8BCBE0F328AF247AEFFDC19).FieldHandle);
			this.PLKFKNHPEHE = array16;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.VintageYellow)
		{
			float[] array17 = new float[-106];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-72AB50CCD6854B3F3914535BDE6F9A8200D314F3).FieldHandle);
			this.PLKFKNHPEHE = array17;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)80)
		{
			float[] array18 = new float[70];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-E94267328F3AA246028047D981FBC157DAA8AA6A).FieldHandle);
			this.PLKFKNHPEHE = array18;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-40))
		{
			float[] array19 = new float[-96];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-E412DD2A599682217839F819655C2EDD63ACCE0A).FieldHandle);
			this.PLKFKNHPEHE = array19;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)78)
		{
			float[] array20 = new float[-17];
			RuntimeHelpers.InitializeArray(array20, fieldof(<PrivateImplementationDetails>.$field-DCF08BCDD530CEE363DB7AD82BEFB88E18891583).FieldHandle);
			this.PLKFKNHPEHE = array20;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-45))
		{
			float[] array21 = new float[-125];
			RuntimeHelpers.InitializeArray(array21, fieldof(<PrivateImplementationDetails>.$field-C01C545B434FB07175CF325EBFFCD67ED3DE871A).FieldHandle);
			this.PLKFKNHPEHE = array21;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.BlackAndWhite_Green)
		{
			float[] array22 = new float[-38];
			RuntimeHelpers.InitializeArray(array22, fieldof(<PrivateImplementationDetails>.$field-78F2104B4C44AAE8B55A2FB998CEA2BCF138DFE1).FieldHandle);
			this.PLKFKNHPEHE = array22;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-99))
		{
			float[] array23 = new float[-68];
			RuntimeHelpers.InitializeArray(array23, fieldof(<PrivateImplementationDetails>.$field-88F414404C40F505B5068F19FA60FB67845A2337).FieldHandle);
			this.PLKFKNHPEHE = array23;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-60))
		{
			float[] array24 = new float[-43];
			RuntimeHelpers.InitializeArray(array24, fieldof(<PrivateImplementationDetails>.$field-1F433BCF156500C744956DC4F6CF72D90171C699).FieldHandle);
			this.PLKFKNHPEHE = array24;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-93))
		{
			float[] array25 = new float[-93];
			RuntimeHelpers.InitializeArray(array25, fieldof(<PrivateImplementationDetails>.$field-4AE342AF681D8556F9F844B2DEAB460CE85F1E00).FieldHandle);
			this.PLKFKNHPEHE = array25;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)62)
		{
			float[] array26 = new float[-51];
			RuntimeHelpers.InitializeArray(array26, fieldof(<PrivateImplementationDetails>.$field-519053662B9633E300410800BCC75679EC16D7AE).FieldHandle);
			this.PLKFKNHPEHE = array26;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)(-45))
		{
			float[] array27 = new float[-46];
			RuntimeHelpers.InitializeArray(array27, fieldof(<PrivateImplementationDetails>.$field-2161BFBA04F65A8DD03880F03451CEAF40D3013C).FieldHandle);
			this.PLKFKNHPEHE = array27;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)61)
		{
			float[] array28 = new float[125];
			RuntimeHelpers.InitializeArray(array28, fieldof(<PrivateImplementationDetails>.$field-9978C64907E23B200B0EDA4D501A89B0F075363C).FieldHandle);
			this.PLKFKNHPEHE = array28;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)91)
		{
			float[] array29 = new float[-17];
			RuntimeHelpers.InitializeArray(array29, fieldof(<PrivateImplementationDetails>.$field-C96F4447805C79FD865B193E0E5231CACB3F7661).FieldHandle);
			this.PLKFKNHPEHE = array29;
		}
		if (this.filterchoice == CameraFilterPack_Colors_Adjust_PreFilters.filters.YellowSunSet)
		{
			float[] array30 = new float[73];
			RuntimeHelpers.InitializeArray(array30, fieldof(<PrivateImplementationDetails>.$field-664308DA52018D3D32B7FB134AF69011874114AC).FieldHandle);
			this.PLKFKNHPEHE = array30;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)82)
		{
			float[] array31 = new float[104];
			RuntimeHelpers.InitializeArray(array31, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
			this.PLKFKNHPEHE = array31;
		}
		if (this.filterchoice == (CameraFilterPack_Colors_Adjust_PreFilters.filters)37)
		{
			float[] array32 = new float[-66];
			RuntimeHelpers.InitializeArray(array32, fieldof(<PrivateImplementationDetails>.$field-BB39BAF6CE0501A417BF105F435F00B6A46E1B09).FieldHandle);
			this.PLKFKNHPEHE = array32;
		}
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x000CB67F File Offset: 0x000C987F
	private void KNBJBNDGCIJ()
	{
		this.POPFEPMJDPF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x000CBDD7 File Offset: 0x000C9FD7
	private void EPEGAEGDJAM()
	{
		this.KPBEDPFEKFI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000466 RID: 1126
	private string ELOFMLPCCEA = "CameraFilterPack/Colors_Adjust_PreFilters";

	// Token: 0x04000467 RID: 1127
	public Shader SCShader;

	// Token: 0x04000468 RID: 1128
	public CameraFilterPack_Colors_Adjust_PreFilters.filters filterchoice;

	// Token: 0x04000469 RID: 1129
	[Range(0f, 1f)]
	public float FadeFX = 1f;

	// Token: 0x0400046A RID: 1130
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400046B RID: 1131
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400046C RID: 1132
	private Material BJFKDHHMLJH;

	// Token: 0x0400046D RID: 1133
	private float[] PLKFKNHPEHE;

	// Token: 0x0200007A RID: 122
	public enum filters
	{
		// Token: 0x0400046F RID: 1135
		Normal,
		// Token: 0x04000470 RID: 1136
		BlueLagoon,
		// Token: 0x04000471 RID: 1137
		BlueMoon,
		// Token: 0x04000472 RID: 1138
		RedWhite,
		// Token: 0x04000473 RID: 1139
		NashVille,
		// Token: 0x04000474 RID: 1140
		VintageYellow,
		// Token: 0x04000475 RID: 1141
		GoldenPink,
		// Token: 0x04000476 RID: 1142
		DarkPink,
		// Token: 0x04000477 RID: 1143
		PopRocket,
		// Token: 0x04000478 RID: 1144
		RedSoftLight,
		// Token: 0x04000479 RID: 1145
		YellowSunSet,
		// Token: 0x0400047A RID: 1146
		Walden,
		// Token: 0x0400047B RID: 1147
		WhiteShine,
		// Token: 0x0400047C RID: 1148
		Fluo,
		// Token: 0x0400047D RID: 1149
		MarsSunRise,
		// Token: 0x0400047E RID: 1150
		Amelie,
		// Token: 0x0400047F RID: 1151
		BlueJeans,
		// Token: 0x04000480 RID: 1152
		NightVision,
		// Token: 0x04000481 RID: 1153
		BlueParadise,
		// Token: 0x04000482 RID: 1154
		Blindness_Deuteranomaly,
		// Token: 0x04000483 RID: 1155
		Blindness_Protanopia,
		// Token: 0x04000484 RID: 1156
		Blindness_Protanomaly,
		// Token: 0x04000485 RID: 1157
		Blindness_Deuteranopia,
		// Token: 0x04000486 RID: 1158
		Blindness_Tritanomaly,
		// Token: 0x04000487 RID: 1159
		Blindness_Achromatopsia,
		// Token: 0x04000488 RID: 1160
		Blindness_Achromatomaly,
		// Token: 0x04000489 RID: 1161
		Blindness_Tritanopia,
		// Token: 0x0400048A RID: 1162
		BlackAndWhite_Blue,
		// Token: 0x0400048B RID: 1163
		BlackAndWhite_Green,
		// Token: 0x0400048C RID: 1164
		BlackAndWhite_Orange,
		// Token: 0x0400048D RID: 1165
		BlackAndWhite_Red,
		// Token: 0x0400048E RID: 1166
		BlackAndWhite_Yellow
	}
}
