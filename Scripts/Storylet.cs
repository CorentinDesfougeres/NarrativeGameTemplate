using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		[CreateAssetMenu(menuName = "Tetri/Sally/Storylet", fileName = "NewStorylet")]
        public class Storylet : SerializedScriptableObject
        {
			[TableList]
			public List<Event> Effects;
        }

	}

}
