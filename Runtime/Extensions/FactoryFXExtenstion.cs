using DesertImage.ECS;
using DesertImage.Enums;
using Framework.FX;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DesertImage.Extensions
{
    public static class FactoryFXExtenstion
    {
        private static ServiceFx Service => _serviceFx ??= Core.Instance.Get<ServiceFx>();

        private static ServiceFx _serviceFx;

        static FactoryFXExtenstion()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            _serviceFx = null;
        }

        #region SPAWN

        public static EffectBase Spawn(this object sender, EffectsId id, Vector3 position)
        {
            return Service.Spawn(id, position, Quaternion.identity, null);
        }

        public static EffectBase Spawn(this object sender, EffectsId id, Transform parent)
        {
            return Service.Spawn(id, parent.position, parent.rotation, parent);
        }

        public static EffectBase Spawn(this object sender, EffectsId id, Vector3 position, Quaternion rotation)
        {
            return Service.Spawn(id, position, rotation, null);
        }

        #endregion
    }
}