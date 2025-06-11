![신궁_타이틀](https://github.com/user-attachments/assets/5f52a3e2-c4f7-47f8-ad15-9ef03de20834)
# 🏹신궁

<img alt="Static Badge" src="https://img.shields.io/badge/%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B8%20%EA%B8%B0%EA%B0%84%3A-2025.05~2025.06-FAB040?style=flat-square&logoColor=white">

> 조선의 국궁을 테마로 한 멀티 활 데스매치 FPS 게임.
<br>플레이어는 현실적인 물리가 적용된 활을 사용하여 적을 물리친다.
>
<br>

## 💁‍♂️ 프로젝트 팀원
| Server | Designer | Client | Client |
|:---:|:---:|:---:|:---:|
| <img src="https://github.com/Lim-Dolphin.png?size=120" width="100"/> | <img src="https://github.com/Developer-EJ.png?size=120" width="100"/> | <img src="https://github.com/sunsi-game.png?size=120" width="100"/> | <img src="https://github.com/j1sung.png?size=120" width="100"/> |
| [임백규](https://github.com/Lim-Dolphin) | [김은재](https://github.com/Developer-EJ) | [김호영](https://github.com/sunsi-game) | [안지성](https://github.com/j1sung) |
<br>

## 📝 주요기능
1. 실시간 인터렉션(멀티)
2. 1인칭 시점과 몰입감
3. 사격 및 전투 매커니즘
<br>

## 💻 Tech Stack
### | Work Stack
<div align="left">
 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/blender/blender-original.svg" width="40" height="40"/>
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/unity/unity-original.svg" width="40" height="40"/>
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40" height="40"/>
 <img src="https://media.licdn.com/dms/image/v2/C4D0BAQFgm5g8rrdzPg/company-logo_200_200/company-logo_200_200/0/1630460711618/exit_games_logo?e=2147483647&v=beta&t=U1RPD7XVp9E-ex118pvgff__5uPKLsEnJCcqMJ4PMeU" width="40" height="40"/>
</div>
<div align="left">
  <img alt="Static Badge" src="https://img.shields.io/badge/Blender-E87D0D?style=flat-square&logo=Blender&logoColor=white">
  <img alt="Static Badge" src="https://img.shields.io/badge/Unity-black?style=flat&logo=Unity&logoColor=white">
  <img alt="Static Badge" src="https://img.shields.io/badge/Photon-004480?style=flat-square&logo=Photon&logoColor=white">
</div>

### | Version Control
<div align="left">
  <!-- GitHub -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg" width="40" height="40"/>
  <!-- Git -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-original.svg" width="40" height="40"/>
</div>
<div align="left">
<img alt="Static Badge" src="https://img.shields.io/badge/Github-181717?style=flat-square&logo=github&logoColor=white">
 <img alt="Static Badge" src="https://img.shields.io/badge/Git-F05032?style=flat-square&logo=git&logoColor=white">
</div>

### | Tools
<div align="left">
  <!-- Notion (공식 SVG) -->
  <img src="https://upload.wikimedia.org/wikipedia/commons/4/45/Notion_app_logo.png" width="40" height="40"/>
  <!-- Jira -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jira/jira-original.svg" width="40" height="40"/>
  <!-- Confluence -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/confluence/confluence-original.svg" width="40" height="40"/>
</div>
<div align="left">
<img alt="Static Badge" src="https://img.shields.io/badge/Notion-000000?style=flat-square&logo=notion&logoColor=white">
 <img alt="Static Badge" src="https://img.shields.io/badge/Jira-0052CC?style=flat-square&logo=jira&logoColor=white">
 <img alt="Static Badge" src="https://img.shields.io/badge/Confluence-172B4D?style=flat-square&logo=confluence&logoColor=white">
</div>
<br>

## 🗂 Directory
```
📂 Assets
  └─📂 Photon
  ├─📂 Scripts
  ├─📂 Prefabs
  ├─📂 Materials
  └─📂 Scenes  
     ├─📂 LBK_Network
       └─ Network_lab.scene (메인 Scene)
     └─📂 LBK_Assets
         ├─ 📂 Animation
         ├─ 📂 AudioSource
         ├─ 📂 Prefabs (게임에 필요한 Prefab)
             ├─ NetworkRunner.prefab (게임에 사용되는 네트워크 러너)
             ├─ Player_Network_Fin_chung.prefab (청나라 게임 플레이어 프리팹)
             └─ Player_Network_Fin_Josen.prefab (조건 게임 플레이어 프리팹)
         ├─ 📂 Scenen
             ├─ Conquer Test.scene (미완 Scene)
             ├─ Death Match Test.scene (데스메치 Scene)
             └─ Practice Test.scene (미완 Scene)
         ├─ 📂 Script
             ├─📂 Beacon (봉화 조작 스크립트, 구현 실패)
             ├─📂 GameScript (Game Mechanism 관련 스크립트)
                └─ Gameplay.cs (게임 Manager)
             ├─📂 Menu (Fusion Menu 관련 스크립트)
             ├─📂 Player (Player 관련 스크립트)    
             ├─📂 UI (UI 관련 스크립트)      
             └─📂 Weapons (무기 관련 스크립트)
         ├─ 📂 Settings
         └─ 📂 Sprite
     
```

## 🚩 Build & Run
1. 빌드 세팅
  Assets → Scenes → LBK_Assets → Scene → DeathMatch → Gameplay → Start_player_cnt 값 설정(반드시 2의 배수로 설정, 최소 2, 최대 10)
2. 빌드
`[Build Setting] → add GotOfArcher.scene → Build`
 ※빌드시 Network_lab.scene, Conquer Test.scene, Death Match Test.scene, Practice Test.scene이 포함되어 있는지 확인

3. 빌드된 파일 실행  `God_Of_Archer.exe`
<br>
- 1 vs 1 빌드 파일 다운 : https://drive.google.com/file/d/1usnTQj-pA_s217_sGoul5Z_3HTJTiZKb/view?usp=sharing <br>

## 🚩 In Unity
1. Network_lab.scene으로 이동
   
2. 실행
<br>

## 🎮 Control & Play
### | Control
|조작|버튼|
|:---:|:---:|
|움직임|W,A,S,D|
|달리기|Shift|
|활 줍기|E|
|활 장전|마우스 좌클릭(Hold)|
|활 쏘기|마우스 좌클릭(Release)|
|활 초기화|R|

### | Play Method
1. Select Match 버튼 클릭
![image](https://github.com/user-attachments/assets/f6883a72-fc72-461f-a699-1dc5d4fc938a)
2. 5 vs 5 버튼 클릭
![image](https://github.com/user-attachments/assets/a133e27d-2572-41b7-9fba-b54db0f946f7)
3. Play 버튼 클릭
![image](https://github.com/user-attachments/assets/eb3514b5-b86a-46f4-bc43-91272b2dfb83)
4. 접속 대기
![image](https://github.com/user-attachments/assets/0e5a8916-a7e2-4052-8b5d-259d509484f5)
5. 게임 플레이
![image](https://github.com/user-attachments/assets/5a661ae0-f529-43eb-a7ec-4bc175c83daa)

## 🔗 관련 링크
- 시연 영상 링크 : <br>https://youtu.be/F4DWmPACwdQ?feature=shared
- Notion : <br>https://acute-library-43c.notion.site/19de57fa71f28068ad51fa3b40ad7889?source=copy_link
- Jira : <br>https://roadofmartialts.atlassian.net/jira/software/projects/SCRUM/boards/1/backlog?selectedIssue=SCRUM-96
- Confluence : <br>https://roadofmartialts.atlassian.net/jira/software/projects/SCRUM/boards/1/backlog?selectedIssue=SCRUM-96
