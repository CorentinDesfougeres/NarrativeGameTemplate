using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.Events;

namespace Tetri
{
	namespace Sally
	{

		[CreateAssetMenu(menuName = "Tetri/Sally/Storylet", fileName = "NewStorylet")]
        public class Storylet : SerializedScriptableObject
        {
			[TableList]
			public List<IStoryletCondition> Conditions;

			[TableList]
			public List<UnityEvent> Effects;

			public int Priority;
        }

	}

}
