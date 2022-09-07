N, M = map(int, input().split())
A = list(map(int, input().split()))
num = 0
for i in range(M):
    num += A[-(i+1)] * (M - i)
max_num = num
add_sum = sum(A[N-M:N])
for i in range(N-M):
    num -= M * A[-(i+1)]
    add_sum += A[N-i-M-1] - A[N-i-1]
    num += add_sum
    if max_num < num:
        max_num = num
print(max_num)
