# NarrativeGameTemplate
A template for making narrative games in Unity. 

The system is composed of storylets, each containing conditions allowing them to run and effect they do once running, and a game manager which check what storylets are currently available and choose among those which one is most relevant to run.

...

Notable inspirations for the system are :
  - Left4Dead dialogue system, as presented by Elan Ruskin in his 2012 GDC Talk ( https://www.youtube.com/watch?v=tAbBID3N64A )
  - Firewatch dialogue system, as presented by William Armstrong and Patrick Ewing in their 2017 GDC talks ( https://www.youtube.com/watch?v=wj-2vbiyHnI )
  - The King Of Chicago Narraton system, as presented by Doug Sharp in his 1989 GDC talk ( https://dougsharp.wordpress.com/story-vs-game-the-battle-of-interactive-fiction/ ) 
  - FailBetter's storylet organisation in Fallen London and in their StoryNexus engine.
  - Various articles by Emily Short on storylet design in general, and salience-based ones in particular. Specifically, my terminology used to describe the design comes from this article : https://emshort.blog/2016/04/12/beyond-branching-quality-based-and-salience-based-narrative-structures/

...

/!\ Dependencies :
  - Odin Inspector is used for the serialisation and to make creating and managing content through the inspector less tedious. Asset store page : https://assetstore.unity.com/packages/tools/utilities/odin-inspector-and-serializer-89041?aid=1100lHSw&utm_source=aff
