using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class audiobutton : MonoBehaviour
{
    public AudioSource buttonSound;
    public GameObject panelAwal;
    public GameObject panelTujuan;

    public void GantiPanelBaru()
    {
        buttonSound.PlayOneShot (buttonSound.clip);
        panelAwal.SetActive(false);
        panelTujuan.SetActive(true);
    }
    public void GantiPanelBaruClicked()
    {
        panelAwal.SetActive(true);
        panelTujuan.SetActive(false);
    }
 
}
