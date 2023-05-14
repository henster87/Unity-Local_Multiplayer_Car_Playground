using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public bool isFlickering = false;
    private Light torch;
    public float randomNumber;
    public float randomBrightness;
    public float rdmStart = 0.1f;
    public float rdmStop = 0.2f;
    public float rdmStart2 = 0.5f;
    public float rdmStop2 = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        torch = GetComponent<Light>();
    }

    IEnumerator RandomGenerator()
    {
        isFlickering = true;
        randomBrightness = Random.Range(5, 30);
        randomNumber = Random.Range(rdmStart, rdmStop);
        torch.intensity = randomBrightness;
        this.gameObject.GetComponent<Light>().enabled = false;
        yield return new WaitForSeconds(randomNumber);
        randomBrightness = Random.Range(5, 30);
        randomNumber = Random.Range(rdmStart2, rdmStop2);
        torch.intensity = randomBrightness;
        this.gameObject.GetComponent<Light>().enabled = true;
        yield return new WaitForSeconds(randomNumber);
        isFlickering = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(RandomGenerator());
        }

    }

}
