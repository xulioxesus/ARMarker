using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public void RotateLeft()
    {
        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Rotate(0, 15, 0);
        }   
    }

    public void RotateRight()
    {
        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Rotate(0, -15, 0);
        }   
    }

    public void PopUp()
    {
        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            Canvas canvas = obj.GetComponentInChildren<Canvas>();
            if (canvas != null)
            {
                canvas.enabled = !canvas.enabled;
            }   
        }   
    }  

    public void PlayAudio()
    {
        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            AudioSource audioSource = obj.GetComponentInChildren<AudioSource>();
            if (audioSource != null)
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Pause();
                }
                else
                {
                    audioSource.Play();
                }
            }   
        }
    } 
}
