## Player Movement

- Input.GetAxisRaw로 입력 처리
- Rigidbody2D.MovePosition으로 이동 구현
- normalized를 사용하여 대각선 속도 보정
- Time.fixedDeltaTime을 곱하여 성능에 관계없이 일정 속도 유지

## Enemy Movement

- Player 태그를 가진 GameObject를 타겟으로 설정
- Rigidbody2D.MovePosition으로 이동 구현
- 타겟과의 방향 벡터를 normalized 하여, 일정 속도로 이동
- Time.fixedDeltaTime을 곱하여 성능에 관계없이 일정 속도 유지