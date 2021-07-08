using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;

namespace Tetri
{
	namespace Sally
	{

        public class Manager : OdinMenuEditorWindow
        {

            [OnValueChanged("StateChange")]
            [LabelText("Manager View")]
            [LabelWidth(100f)]
            [EnumToggleButtons]
            [ShowInInspector]
            public ManagerState managerState;
            private int enumIndex = 0;
            private bool treeRebuild = false;

            private DrawSelected<Storylet> drawStorylet = new DrawSelected<Storylet>();
            private string StoryletPath = "Assets/NarrativeGameTemplate/Data/Storylets"; // should be public in a settings tab
            private DrawSelected<WorldStateCodex> drawWorldState = new DrawSelected<WorldStateCodex>();
            private string WorldStatePath = "Assets/NarrativeGameTemplate/Data/World State";  // should be public in a settings tab

			[MenuItem("Tools/Sally's Manager")]
			public static void OpenWindow()
			{
				GetWindow<Manager>().Show();
			}

            private void StateChange()
            {
                treeRebuild = true;
            }

            protected override void Initialize()
            {
                drawStorylet.SetPath(StoryletPath);
                drawWorldState.SetPath(WorldStatePath);
            }

            protected override void OnGUI()
            {
                
                SirenixEditorGUI.Title("Sallient Game Master" , "Asset Management" , TextAlignment.Center, true);
                EditorGUILayout.Space();

                if (treeRebuild && Event.current.type == EventType.Layout)
                {
                    ForceMenuTreeRebuild();
                    treeRebuild = false ;
                }

                switch (managerState)
                {
                    // Put the states we want a menu for here, let the rest fall through. The Default Enum value can't have a menu.
                    case ManagerState.Storylets :
                    case ManagerState.WorldState :
                        DrawEditor(enumIndex);
                        break;
                    default:
                        break;
                }

                base.OnGUI();
            }

            protected override void DrawEditors()
            {
                switch (managerState)
                {
                    case ManagerState.HomePage :
                        DrawEditor(enumIndex);
                        break;
                    case ManagerState.Storylets :
                        drawStorylet.SetSelected(this.MenuTree.Selection.SelectedValue);
                        break;
                    case ManagerState.WorldState :
                        drawWorldState.SetSelected(this.MenuTree.Selection.SelectedValue);
                        break;
                    default:
                        break;
                }

                DrawEditor((int)managerState);
            }

            protected override IEnumerable<object> GetTargets()
            {
                List<object> targets = new List<object>();
                
                targets.Add(null);
                targets.Add(drawStorylet);
                targets.Add(drawWorldState);

                targets.Add(base.GetTarget());

                enumIndex = targets.Count - 1;

                return targets;
            }

            protected override void DrawMenu()
            {
                switch (managerState)
                {
                    // Put the states we want a menu for here, let the rest fall through. The Default Enum value can't have a menu.
                    case ManagerState.Storylets :
                    case ManagerState.WorldState :
                        base.DrawMenu();
                        break;
                    default:
                        break;
                }
            }

            protected override OdinMenuTree BuildMenuTree()
            {
                OdinMenuTree tree = new OdinMenuTree();

                switch (managerState)
                {
                    case ManagerState.Storylets :
                        tree.AddAllAssetsAtPath("Storylets" , StoryletPath , typeof(Storylet));
                        break;
                    case ManagerState.WorldState :
                        tree.AddAllAssetsAtPath("World State Codexes" , WorldStatePath , typeof(WorldStateCodex));
                        break;
                    default:
                        break;
                }

                return tree;
            }

            public enum ManagerState
            {
                HomePage,
                Storylets,
                WorldState,
            }
            
        }

    }
}