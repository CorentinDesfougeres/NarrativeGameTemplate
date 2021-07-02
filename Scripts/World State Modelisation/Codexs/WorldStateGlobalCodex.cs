using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		[CreateAssetMenu(menuName = "Tetri/Sally/World State", fileName = "NewWorldState")]
		public class WorldStateCodex : SerializedScriptableObject , IWorldStateCodex
		{

			#region  IWorldStateCodex implementation

			[TableList]
			public List<IWorldStateTag> Tags{get;set;}

			#endregion



		}
	
	}
}