using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		[CreateAssetMenu(menuName = "Tetri/Sally/Salient Game Master" , fileName = "NewSalientGameMaster")]
		public class SalientGameMaster : SerializedScriptableObject
		{
			public ISalienceRule SalienceRule;
		}
	
	}
}