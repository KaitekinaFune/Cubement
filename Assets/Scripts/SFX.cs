using UnityEngine;

public class SFX : MonoBehaviour
{
	public AudioSource ScoreSound;
	public AudioSource SlamSound;

	public void PlayScoreSound ()
	{
		ScoreSound.Play();
	}
	public void PlaySlamSound()
	{
		SlamSound.Play();
	}
}
