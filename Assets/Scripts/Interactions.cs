using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public Button emailButton;
    public Button GitHubButton;
    public Button twitterButton;
    public Button linkedInButton;

    public AudioSource clickSound; 
    

   
    void Start()
    {
       
        emailButton.onClick.AddListener(() => OpenLink("mailto:v.bamurange@alustudent.com"));
        GitHubButton.onClick.AddListener(() => OpenLink("https://github.com/VBamurange"));
        twitterButton.onClick.AddListener(() => OpenLink("https://x.com/VGahunde51218"));
        linkedInButton.onClick.AddListener(() => OpenLink("https://linkedin.com/in/victoria-bamurange-b96650247"));

        
        emailButton.onClick.AddListener(() => ButtonFeedback(emailButton));
        GitHubButton.onClick.AddListener(() => ButtonFeedback(GitHubButton));
        twitterButton.onClick.AddListener(() => ButtonFeedback(twitterButton));
        linkedInButton.onClick.AddListener(() => ButtonFeedback(linkedInButton));
    }

   
    void OpenLink(string url)
    {
        Application.OpenURL(url);
    }

    
    void ButtonFeedback(Button button)
    {
        //StartCoroutine(ButtonPressEffect(button));
        clickSound.Play();
    }
}
