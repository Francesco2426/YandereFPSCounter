using UnityEngine;
using TMPro;

public class FPS : MonoBehaviour
{
    public TextMeshProUGUI fps;
    public float notRandom;

    void Update()
    {
        fps.text = notRandom.ToString();
        StartCoroutine(RandomGen())
    }
    IEnumerator RandomGen()
    {
        yield return new WaitForSeconds(1.5f);
        notRandom = Random.Range(60f, 120f)
    }
}