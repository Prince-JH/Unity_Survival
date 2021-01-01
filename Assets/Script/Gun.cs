using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public string gunName; //총의 이름
    public float range; //사정 거리
    public float accracy; //정확도
    public float fireRate; //연사 속도
    public float reloadTime; //장전 속도

    public int damage;
    public int reloadBulletCount; //한 탄창 총알 개수
    public int currentBulletCount; //현재 총알 개수
    public int maxBulletCount; //최대 소유 가능 총알 개수
    public int carryBulletCount; //현재 소유하고 있는 총알 개수

    public float retroActionForce; //반동 세기
    public float retroActionFineSightForce; //정조준시의 반동 세기

    public Vector3 fineSightOriginPos;
    public Animator anim;
    public ParticleSystem muzzleFlash;
    public AudioClip fireSound;
   
}
