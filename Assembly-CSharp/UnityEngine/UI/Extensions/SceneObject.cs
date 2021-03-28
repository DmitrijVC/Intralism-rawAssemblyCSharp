using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002C3 RID: 707
	[Serializable]
	public class SceneObject
	{
		// Token: 0x040012D5 RID: 4821
		public string name;

		// Token: 0x040012D6 RID: 4822
		public string prefabName;

		// Token: 0x040012D7 RID: 4823
		public string id;

		// Token: 0x040012D8 RID: 4824
		public string idParent;

		// Token: 0x040012D9 RID: 4825
		public bool active;

		// Token: 0x040012DA RID: 4826
		public Vector3 position;

		// Token: 0x040012DB RID: 4827
		public Vector3 localScale;

		// Token: 0x040012DC RID: 4828
		public Quaternion rotation;

		// Token: 0x040012DD RID: 4829
		public List<ObjectComponent> objectComponents = new List<ObjectComponent>();
	}
}
