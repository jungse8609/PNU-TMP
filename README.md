# Revolution Of Weapons
부산대 컴퓨터 그래픽스 3D 게임 개발 프로젝트입니다.
프로젝트 명은 "Revolution Of Weapon, 무기들의 반란" 입니다.

## 작업 환경
Unity Editor : 6000.0.30f1

##기획
뱀서라이크 게임으로 몰려오는 몬스터으로부터 생존하며 무기와 능력치를 강화합니다.   
보스 몬스터를 처치해 새로운 무기를 얻을 수 있습니다.

### 조작
- 좌클릭 : 공격
- r : 리로딩
- wasd : 이동

### 캐릭터
**공격**
- 커서 방향으로 좌클릭 발사
- 탄창과 재장전 시간 있음
- 탄창은 무기 종류에 따라 다름

**스탯**
- 이동속도
- 체력 증가
- 체력 재생력

**능력 강화**
- 일정 시간마다 나오는 보스를 처치하면 랜덤 무기를 획득할 수 있다.(이때 무기는 겹치지 않는다.)
- 능력치 강화는 `레벨업`을 통해 가능
  - 잡몹을 잡아 나온 `보석`을 주워 경험치를 획득할 수 있다.
  - 레벨업 시 랜덤으로 뜨는 3개의 능력치 중 하나를 선택할 수 있다.
- 강화 가능한 능력치
    - 이동속도 강화
    - 체력 증가
    - 체력 재생력
- 강화 가능한 무기 스탯
    - 공격력
    - 공속
    - 총알 속도
    - 리로딩 쿨타임 감소

### 무기 종류
  
**권총**
  - 디폴트 무기
  - 한 방향 공격

**라이플**
  - 빠른 공격 속도
  - 한 방향 공격

**샷건**
  - 근거리에 강한 피해
  - 산탄 공격

**저격총**
  - 강한 데미지
  - 한 방향 관통 공격   

### 몬스터

**잡몹**
- 시간에 따라 리스폰 횟수 증가
- `NAV MESH`를 사용한 AI 구현

**보스**
- 일정 시간마다 리스폰되는 잡몹보다 강한 몬스터
- 사망 시 랜덤한 무기를 떨어뜨림
- 캐릭터와 멀리 떨어지면 스크린 밖에 텔레포트

### UI
- 메인화면
    - 게임 시작하기
    - 게임 종료하기
- 인게임
    - 타이머
    - ESC 누르면 퍼즈창
        - 게임으로 돌아가기
        - 메인메뉴로 가기

### 맵
- 무한맵

### 역할
**영환**
- 캐릭터, 몬스터, 배경의 3d 모델링, 텍스처링
- 포스트프로세싱

**재영**
- 몬스터(잡몹, 보스) : `NAV MESH` 사용해서 플레이어 오브젝트 따라가기

**국경**
- 캐릭터 로직(이동, 공격, 능력치 기능)
- 총 프리팹 제작

**현진**
- UI 제작(위 기능 참고)
- 레벨업 시스템
- 능력 강화
- 무한맵 제작

### 일정
![image](https://github.com/user-attachments/assets/8524504d-6f50-409e-bb90-96f531c2d8d8)
