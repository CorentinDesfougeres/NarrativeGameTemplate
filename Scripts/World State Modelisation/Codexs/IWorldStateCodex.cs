using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace Tetri
{
    namespace Sally
    {
        
        public interface IWorldStateCodex
        {

			[TableList]
			List<IWorldStateTag> Tags{get;set;}
			
        }

    }
}
