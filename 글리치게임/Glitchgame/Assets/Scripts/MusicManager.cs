using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    public AudioClip[] levelMusicChangeArray; //음악을 넣을 수 있는 배열 저장

    private AudioSource audioSource;
    void Awake() //start 함수보다 빨리 호출되는 함수 start 함수와 마찬가지로 한번만 호출된다.
    {
        DontDestroyOnLoad(gameObject);   //게임오브젝트가 유지되게 해주는 함수
        Debug.Log("Dont' destroy " + name);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //게임이 시작되면 오디오소스 변수에 오디오소스컴포넌트를 가져온다
    }
	
   void OnLevelWasLoaded (int level) //onlevelwasloaded 는 다음씬이 넘어갈때 실행되는 함수
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing clip" + thisLevelMusic);

        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
