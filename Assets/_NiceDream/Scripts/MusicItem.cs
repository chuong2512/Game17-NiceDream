using UnityEngine;
using UnityEngine.UI;

public class MusicItem : MonoBehaviour
{
    public Image iconImage;
    public Button button;
    public GameObject lockObj, chooseObj;

    public void Choose()
    {
        chooseObj.SetActive(true);
    }

    public void UnChoose()
    {
        chooseObj.SetActive(false);
    }

    public void Init(Sprite sprite, int id, MusicSelector musicSelector)
    {
        iconImage.sprite = sprite;

        button.onClick.AddListener(() => { musicSelector.ChooseMusic(id); });
    }

    public void Unlock()
    {
        lockObj.SetActive(false);
    }
}