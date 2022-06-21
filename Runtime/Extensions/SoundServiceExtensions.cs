using DesertImage.Audio;
using DesertImage.ECS;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DesertImage.Extensions
{
    public static class SoundServiceExtensions
    {
        private static ServiceSound Service => _service ??= Core.Instance?.Get<ServiceSound>();

        private static ServiceSound _service;

        static SoundServiceExtensions()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += SceneManagerOnsceneUnloaded;
        }

        private static void SceneManagerOnsceneUnloaded(Scene arg0)
        {
            _service = null;
        }

        private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            _service = null;
        }

        public static SoundBase PlaySound(this object sender, ushort id, float volume = 1f, float pitch = 1f,
            bool forceStop = false, bool isSingle = false)
        {
            return Service?.Spawn2D(id, volume, false, pitch, forceStop, isSingle);
        }

        public static SoundBase PlaySound(this object sender, ushort id, ushort layerId, float volume = 1f,
            float pitch = 1f, bool isLooped = false, bool forceStop = false, bool isSingle = false)
        {
            return Service?.Spawn2D(id, layerId, volume, isLooped, pitch, forceStop, isSingle);
        }

        public static SoundBase PlaySound(this object sender, ushort id, bool isLooped, float volume = 1f,
            float pitch = 1f, bool forceStop = false, bool isSingle = false)
        {
            return Service?.Spawn2D(id, volume, isLooped, pitch, forceStop, isSingle);
        }

        public static SoundBase PlaySound(this object sender, AudioClip audioClip, float volume = 1f, float pitch = 1f)
        {
            return Service?.Spawn2D(audioClip, 0, volume, false, pitch);
        }

        public static SoundBase PlaySound(this object sender, ushort[] ids, ushort layerId, float volume = 1f,
            float pitch = 1f)
        {
            return Service?.Spawn2D(ids, layerId, volume, pitch);
        }

        public static AudioSource GetAudioSource(this object sender)
        {
            return Service?.GetAudioSource();
        }

        public static AudioClip GetTrack(this object sender, ushort id)
        {
            return Service.GetTrack(id);
        }

        public static float GetLength(this object sender, ushort id)
        {
            return Service.GetTrackLength(id);
        }

        public static float GetLength(this ushort[] ids)
        {
            return Service.GetTrackLength(ids);
        }

        public static SoundBase GetReadySoundBase(this object sender, ushort id)
        {
            return Service.GetReadySoundBase(id);
        }
    }
}