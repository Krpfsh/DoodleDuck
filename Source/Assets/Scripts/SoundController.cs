using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public Slider sliderVolumeMusic;
    public float volume;

    void Start()
    {
        Load();
        ValueMusic();       
        sliderVolumeMusic = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
    }

    private void Update()
    {
        SliderMusic();
    }
    public void SliderMusic()
    {
        volume = sliderVolumeMusic.value;
        Save();
        ValueMusic();
    }

    public void ToggleMusic()
    {
        Save();
        ValueMusic();
    }

    private void ValueMusic()
    {
        
        AudioListener.volume = sliderVolumeMusic.value;
        sliderVolumeMusic.value = volume;
       
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", volume);
    }

    private void Load()
    {
        volume = PlayerPrefs.GetFloat("volume", volume);
    }
}
