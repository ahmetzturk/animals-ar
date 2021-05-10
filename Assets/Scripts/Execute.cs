using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Execute : MonoBehaviour
{
    [HideInInspector] public AnimalType activeAnimal = AnimalType.None;

    public void ExecuteIt()
    {
        Animal[] animals = FindObjectsOfType<Animal>();

        foreach (var animal in animals)
        {
            if(animal.AnimalType == activeAnimal)
            {
                animal.gameObject.GetComponent<AudioSource>().Play();

                animal.gameObject.GetComponent<Animator>().enabled = false;
                animal.gameObject.GetComponent<Animator>().Play("Take 001", -1, 0f);
                animal.gameObject.GetComponent<Animator>().enabled = true;
            }
            else
            {
                animal.gameObject.GetComponent<AudioSource>().Stop();
                animal.gameObject.GetComponent<Animator>().enabled = false;
            }
        }
    }

    public void StopIt()
    {
        Animal[] animals = FindObjectsOfType<Animal>();

        foreach (var animal in animals)
        {         
            animal.gameObject.GetComponent<AudioSource>().Stop();
            animal.gameObject.GetComponent<Animator>().enabled = false;         
        }
    }

}
