# Tetris 

AccScr는 Screen 클래스를 상속받아서 구현했다. 
Screen의 천장, 바닥 부분을 빼고 누적되는 블록을 
처리하는 클래스인데 천장, 바닥 부분 빼고 구현하다 보니 
SetTile() 부분에서 쌓인 위치와 실제 Render() 되는 부분
위치 차이를 보정해주는 부분에서 code 해석이 어렵다. 
학습을 위해 AccScr을 상속받아서 구현했으나 
code 가독성을 위해서는 Screen에서 동일한 SetTile()을 
사용하거나 위치보정해주는 AccScrToScreenTranslate() 
함수를 구현해서 필요한 위차에 사용하면 code가 좀 더 
깔끔해질 것으로 보인다. 
