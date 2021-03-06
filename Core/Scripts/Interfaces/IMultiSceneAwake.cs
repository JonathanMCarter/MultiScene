// Multi Scene - Core
// A interface to implement when you want logic to run first once a scene group has loaded via the multi-scene manager.
// Author: Jonathan Carter - https://carter.games

namespace MultiScene.Core
{
    public interface IMultiSceneAwake
    {
        void OnMultiSceneAwake();
    }
}