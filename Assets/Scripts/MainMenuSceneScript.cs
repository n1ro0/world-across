using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class MainMenuSceneScript : MonoBehaviour
    {
        public string gameScene;
        public Button VolumeButton;
        public Sprite soundOff;
        public Sprite soundOn;
        //public Animator ButtonAnimator;
        void Start ()
        {
			if (!PlayerPrefs.HasKey ("SoundEnabled")) 
			{
				PlayerPrefs.SetInt ("SoundEnabled", 1);
				VolumeButton.image.sprite = soundOn;
				AudioListener.pause = false;
			} 
			else 
			{
				if (PlayerPrefs.GetInt("SoundEnabled") == 1)
				{
					VolumeButton.image.sprite = soundOn;
					AudioListener.pause = false;
				}
				else
				{                
					VolumeButton.image.sprite = soundOff;
					AudioListener.pause = true;
				}
			}
        }
	
        // Update is called once per frame
        void Update () {
	
        }

        public void StartGame()
        {
            Application.LoadLevel(gameScene);
        }

        public void ChangeVolumeStatus()
        {
            if (VolumeButton.image.sprite==soundOff)
            {
                VolumeButton.image.sprite = soundOn;
				AudioListener.pause = false;
				PlayerPrefs.SetInt ("SoundEnabled", 1);
            }
            else
            {
                VolumeButton.image.sprite = soundOff;
				AudioListener.pause = true;
				PlayerPrefs.SetInt ("SoundEnabled", 0);
            }
        }

    }
}
