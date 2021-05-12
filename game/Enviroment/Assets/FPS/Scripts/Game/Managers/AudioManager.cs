using UnityEngine;
using UnityEngine.Audio;

namespace Unity.FPS.Game
{
    public class AudioManager : MonoBehaviour
    {
        [FMODUnity.EventRef]
        public string eventPath_Ambience;
        FMOD.Studio.EventInstance ambienceState;

        [SerializeField][Range(0f, 2f)]
        private float ambience_wind;



        void Awake()
        {
            ambienceState = FMODUnity.RuntimeManager.CreateInstance(eventPath_Ambience);
            ambience_wind = 2f;
            ambienceState.setParameterByName("Ambience_Wind", ambience_wind);
            ambienceState.start();
        }

        void Update()
        {
            //if outside
            //if inside
            //if down

            //ambienceState.setParameterByName("Ambience_Wind", ambience_wind);
        }
    }
}