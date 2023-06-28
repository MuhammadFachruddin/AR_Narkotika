using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pindahpanel : MonoBehaviour
{
    public GameObject panelAwal;
    public GameObject panelTujuan;

    public void GantiPanelBaru()
    {
        panelAwal.SetActive(false);
        panelTujuan.SetActive(true);
    }
    public void GantiPanelBaruClicked()
    {
        panelAwal.SetActive(true);
        panelTujuan.SetActive(false);
    }
 
}
