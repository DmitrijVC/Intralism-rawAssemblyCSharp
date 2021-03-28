using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002C2 RID: 706
	[Serializable]
	public class SaveGame
	{
		// Token: 0x0600A8B4 RID: 43188 RVA: 0x003EA41B File Offset: 0x003E861B
		public SaveGame()
		{
		}

		// Token: 0x0600A8B5 RID: 43189 RVA: 0x003EA439 File Offset: 0x003E8639
		public SaveGame(string BDIMLMKEEKO, List<SceneObject> IKJEHKHOGLD)
		{
			this.savegameName = BDIMLMKEEKO;
			this.sceneObjects = IKJEHKHOGLD;
		}

		// Token: 0x040012D3 RID: 4819
		public string savegameName = "New SaveGame";

		// Token: 0x040012D4 RID: 4820
		public List<SceneObject> sceneObjects = new List<SceneObject>();
	}
}
