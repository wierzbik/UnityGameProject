using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenaKoncowa : MonoBehaviour
{

    public AudioClip deathScreenSound;
    public float speed;
    AudioSource source;
    Image end;
    Text deathText;
    GameObject buttons;
    bool isFaded = false;

    void OnEnable()
    {
        end = transform.Find("Image").GetComponent<Image>();
        deathText = transform.Find("Text").GetComponent<Text>();
        buttons = transform.Find("Buttons").gameObject;
        source = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();

        deathText.canvasRenderer.SetAlpha(0.0f);
        foreach (Transform button in buttons.transform)
        {
            button.Find("Text").GetComponent<Text>().canvasRenderer.SetAlpha(0.0f);
        }
        source.PlayOneShot(deathScreenSound);
        end.material.SetFloat("_Level", 1.0f);
        StartCoroutine(FadeScreen());
    }

    void Update()
    {
        if (end.material.GetFloat("_Level") <= 0 && isFaded == false)
        {
            isFaded = true;
            deathText.CrossFadeAlpha(1.0f, 1.0f, false);
            foreach (Transform button in buttons.transform)
            {
                button.Find("Text").GetComponent<Text>().CrossFadeAlpha(1.0f, 1.0f, false);
            }
        }
    }

    IEnumerator FadeScreen()
    {
        float t = 1f;
        while (t > 0)
        {
            t -= Time.deltaTime * speed;
            end.material.SetFloat("_Level", t);
            yield return null;
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("poziom1");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("menu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

}
