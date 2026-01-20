# Project Template
This project contains a base achitecture for a Unity game, with a tool for creating game submodules that automatically sets up new assembly definitions and their dependencies.

The project is split into multiple assemblies, with the goal of isolating MonoBehaviours from the core game logic. This allows more strict management of game state, and all operations that modify the state should be encapsulated in commands, with services for more complex operations.

# Basic Operation

## Start
**SceneService** contains the static **LoadCoreScenes()** which has a **RuntimeInitializeOnLoadMethod** which will load the core Game scene. The Game scene contains the main Game prefab which will act as a public static singleton that can be used to issue commands and read the current Model. The Game prefab contains the ViewServiceManager which will serve as a parent to any Services that must be MonoBehaviours. 

When Game initializes, it will search the assembly for all classes implementing **IService**. For classes inheriting MonoBehaviour, it will search for an existing instance and cache a reference, otherwise it will create a new instance. For non-MonoBehaviour services, it will create an instance using Activator.CreateInstance().

Game creates two key Updaters: **TimeUpdater** updates the **TimeModel** every frame, usually with Unity's Time values. **InputUpdater** handles user input and has an internal state machine which handles inputs in different contexts.

Game contains a serialized reference to a **DataReferences** object. This object contains references all the core data collections. In order to trigger the OnEnable() which registers the data with the **DataService**, a reference is needed, so it is loaded with the **Game** prefab.

Game creates a new empty instance of **GameModel**. This object should contains all important game state. 
# New Project Setup
* Add any MonoBehaviour **Service** that needs preconfigured serialized fields to a core scene so they are found and cached on start. 
* Create InputStates to handle user input. On boot, force an initial state to override the default Inactive state of the **InputUpdater**.
* Create a new **DataReferences** asset to manage your asset references. This asset needs to be referenced by a loaded asset, such as a MonoBehaviour instance, in order to be loaded. It only need to be loaded once.
* Create a new **IRegisteredData** asset for each type of asset collection and add them each to your new **DataReferences** asset. Commonly used **IRegisteredData** types are **KeyHoldertoPrefabReferenceLookup** for finding assets by key.
* In ViewModel, add references to your new IModels to IGameModel.
* In Model, fill out GameModel with any new Models and fill the IGameModel implementation section.

# Key Scripts

## ICommand
Commands are the main way to make changes to the GameMode. Each Command encapsulates a singled operation. Commands are run by passing them to Game.Do() to enqueue them. Each frame, Game flushes the command queue and runs each command in sequence. It's common for commands to enqueue further commands.

## IIdentifiable(ViewModel)
This ViewModel is the base class for all ViewModels containing a Guid. This class is used throughout the core code for managing Identifiable objects, so it all ViewModels with unique Ids should implement it.

## IdentifiableCollection
This Model implements IIdentifiableCollection and is usually used to aggregate all Models of a given type. It can be iterated over, and Models can be retrieved with their Id as a key.

## Identifiable(Component)
This component stored an Id to associate one of more Models with a GameOject. Identifiables come in two types:
* **SerializedIdentifiable** contains a unique serialized ID. It is used for singletons and objects instantiated in scenes.
* **ModelIdentifiable** is used for GameObjects instantiated at runtime. Their ID is assigned by the object that creates them, usually a **ViewSpawner**.
## Tracked Transforms
This component goes on GameObjects with Identifiables attached. It allows finding gameojects using their Id instead of a normal Unity reference. When an Id is assigned to the Identifiable component, the Transform is registered with the TransformService, and can be fetched again using a matching Id.

## ViewSpawner
This component serves as a base class to spawn GameObjects with a counterpart IdentifiableCollection in Models. It registers events to handle adding to and removing from Model collections, and creating and destroying their GameObjects.

# Assemblies
Each assembly has a core role in the project, and has a counter part in the submodules.

## Core
Shared dependencies for all other assemblies, contains some common data types and type extensions.

## Data
Contains scripts for managing ScriptableObjects and prefabs. All scripts for managing data assets should be here.

*Explain different data collection types.*

*Explain KeyAssets and KeyHolders.*

## Game
Core game logic for managing the model. Contains all Commands and Services.
### InputUpdater
*Explain how InputUpdater is used.*

## Model
Contains all game state. Should not have any state changing logic.

## View
Should contain almost all MonoBehaviours. This assembly only has access to ViewModel and Game so it should read from the view model, and issue commands if it needs to change state.

## ViewModel
Contains only interfaces implemented by Model classes, with getters only. Used by View to update game state.
