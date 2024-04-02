using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{

    [SerializeField]
    private AudioMixer audioMixer;
    void Start()
    {
        //audioMixer.SetFloat("VolumeMusique", -30f);
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertToLogarithmique (volume));
    }



    private float ConvertToLogarithmique(float volume){
        return Mathf.Log10(volume) * 20;
    }


}
