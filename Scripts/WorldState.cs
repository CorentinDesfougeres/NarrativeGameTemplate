using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace Tetri
{
    namespace Sally
    {

        [CreateAssetMenu(menuName = "Tetri/Sally/World State", fileName = "NewWorldState")]
        public class WorldState : SerializedScriptableObject
        {

			[TableList]
			public List<bool> Tags;
			
			[TableList]
			public List<int> Values;

        }

    }
}
