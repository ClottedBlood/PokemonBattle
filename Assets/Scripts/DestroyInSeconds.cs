using UnityEngine;
using System.Collections;

public class DestroyInSeconds : MonoBehaviour
{

    [SerializeField]

    private float secondsToDestroy = 2f;

    private void OnEnable()
    {
        StartCoroutine(DestroyAfterSeconds());
    }

    private IEnumerator DestroyAfterSeconds()
    {
        yield return new WaitForSeconds(secondsToDestroy);
        gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
