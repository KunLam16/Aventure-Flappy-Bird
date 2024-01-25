using UnityEngine;
using UnityEngine.SceneManagement;

public class ChucNangMenu : MonoBehaviour
{
    public GameObject canvasLV;
    public void ChoiMoi()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void ThoatRaMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Thoat()
    {
        Application.Quit();
    }
    public void GoToLevel2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;
    }
    public void GoToLevel3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1.0f;
    }
    public void hienThiMenuLV()
    {
        canvasLV.GetComponent<Canvas>().enabled = true;
    }
    public void closeMenuLV()
    {
        canvasLV.GetComponent<Canvas>().enabled = false;
    }
}
