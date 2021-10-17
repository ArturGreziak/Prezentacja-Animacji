using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPlayer : MonoBehaviour
{
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Stepowanie();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Siadanie();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Skradanie();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Bieganie();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Rozgladanie();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Przemowa();
        }
    }

    public void Stepowanie()
    {
        Anim.SetTrigger("Stepowanie");
    }

    public void Siadanie()
    {
        Anim.SetTrigger("Siadanie");
    }

    public void Skradanie()
    {
        Anim.SetTrigger("Skradanie");
    }

    public void Bieganie()
    {
        Anim.SetTrigger("Bieganie");
    }

    public void Rozgladanie()
    {
        Anim.SetTrigger("Rozgladanie");
    }

    public void Przemowa()
    {
        Anim.SetTrigger("Przemowa");
    }
}
